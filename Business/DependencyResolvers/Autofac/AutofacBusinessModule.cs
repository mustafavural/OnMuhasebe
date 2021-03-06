﻿using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Interceptors.Autofac;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StokManager>().As<IStokService>();
            builder.RegisterType<StokGrupManager>().As<IStokGrupService>();
            builder.RegisterType<StokGrupKodManager>().As<IStokGrupKodService>();
            builder.RegisterType<StokHareketManager>().As<IStokHareketService>();
            builder.RegisterType<DepoManager>().As<IDepoService>();

            //builder.RegisterType<CariManager<Cari>>().As<ICariService<Cari>>();
            //builder.RegisterType<SahisCariManager>().As<ISahisCariService>();
            //builder.RegisterType<SirketCariManager>().As<ISirketCariService>();
            //builder.RegisterType<CariGrupManager>().As<ICariGrupService>();
            //builder.RegisterType<CariGrupKodManager>().As<ICariGrupKodService>();
            //builder.RegisterType<CariHareketManager>().As<ICariHareketService>();

            //builder.RegisterType<FaturaManager>().As<IFaturaService>();
            //builder.RegisterType<IrsaliyeManager>().As<IIrsaliyeService>();

            //builder.RegisterType<DegerliKagitManager<DegerliKagit>>().As<IDegerliKagitService<DegerliKagit>>();
            //builder.RegisterType<CekManager<Cek>>().As<ICekService<Cek>>();
            //builder.RegisterType<SenetManager<Senet>>().As<ISenetService<Senet>>();
            //builder.RegisterType<BorcCekManager>().As<IBorcCekService>();
            //builder.RegisterType<MusteriCekManager>().As<IMusteriCekService>();
            //builder.RegisterType<BorcSenetManager>().As<IBorcSenetService>();
            //builder.RegisterType<MusteriSenetManager>().As<IMusteriSenetService>();

            //builder.RegisterType<PersonelManager>().As<IPersonelService>();
            //builder.RegisterType<PersonelHareketManager>().As<IPersonelHareketService>();

            //builder.RegisterType<KasaManager>().As<IKasaService>();
            //builder.RegisterType<KasaHareketManager>().As<IKasaHareketService>();

            //builder.RegisterType<BankaManager>().As<IBankaService>();
            //builder.RegisterType<BankaSubeManager>().As<IBankaSubeService>();
            //builder.RegisterType<BankaHesapManager>().As<IBankaHesapService>();
            //builder.RegisterType<BankaHesapHareketManager>().As<IBankaHesapHareketService>();

            //----------------------------------------------------------------------------------------------
            //----------------------------------------------------------------------------------------------

            builder.RegisterType<EFStokDal>().As<IStokDal>();
            builder.RegisterType<EFStokGrupDal>().As<IStokGrupDal>();
            builder.RegisterType<EFStokGrupKodDal>().As<IStokGrupKodDal>();
            builder.RegisterType<EFStokHareketDal>().As<IStokHareketDal>();
            builder.RegisterType<EFDepoDal>().As<IDepoDal>();

            //builder.RegisterType<EFCariDal<Cari>>().As<ICariDal<Cari>>();
            //builder.RegisterType<EFCariDal<SahisCari>>().As<ICariDal<SahisCari>>();
            //builder.RegisterType<EFCariDal<SirketCari>>().As<ICariDal<SirketCari>>();
            //builder.RegisterType<EFCariGrupDal>().As<ICariGrupDal>();
            //builder.RegisterType<EFCariGrupKodDal>().As<ICariGrupKodDal>();
            //builder.RegisterType<EFCariHareketDal>().As<ICariHareketDal>();

            //builder.RegisterType<EFEvrakDal<Evrak>>().As<IEvrakDal<Evrak>>();
            //builder.RegisterType<EFEvrakDal<Fatura>>().As<IEvrakDal<Fatura>>();
            //builder.RegisterType<EFEvrakDal<Irsaliye>>().As<IEvrakDal<Irsaliye>>();

            //builder.RegisterType<EFDegerliKagitDal<DegerliKagit>>().As<IDegerliKagitDal<DegerliKagit>>();
            //builder.RegisterType<EFDegerliKagitDal<Cek>>().As<IDegerliKagitDal<Cek>>();
            //builder.RegisterType<EFDegerliKagitDal<MusteriCek>>().As<IDegerliKagitDal<MusteriCek>>();
            //builder.RegisterType<EFDegerliKagitDal<BorcCek>>().As<IDegerliKagitDal<BorcCek>>();
            //builder.RegisterType<EFDegerliKagitDal<Senet>>().As<IDegerliKagitDal<Senet>>();
            //builder.RegisterType<EFDegerliKagitDal<MusteriSenet>>().As<IDegerliKagitDal<MusteriSenet>>();
            //builder.RegisterType<EFDegerliKagitDal<BorcSenet>>().As<IDegerliKagitDal<BorcSenet>>();

            //builder.RegisterType<EFPersonelDal>().As<IPersonelDal>();
            //builder.RegisterType<EFPersonelHareketDal>().As<IPersonelHareketDal>();

            //builder.RegisterType<EFKasaDal>().As<IKasaDal>();
            //builder.RegisterType<EFKasaHareketDal>().As<IKasaHareketDal>();

            //builder.RegisterType<EFBankaDal>().As<IBankaDal>();
            //builder.RegisterType<EFBankaSubeDal>().As<IBankaSubeDal>();
            //builder.RegisterType<EFBankaHesapDal>().As<IBankaHesapDal>();
            //builder.RegisterType<EFBankaHesapHareketDal>().As<IBankaHesapHareketDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly)
               .AsImplementedInterfaces()
               .EnableInterfaceInterceptors
                (new Castle.DynamicProxy.ProxyGenerationOptions
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}