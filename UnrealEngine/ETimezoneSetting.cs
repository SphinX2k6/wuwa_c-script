using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015A3 RID: 5539
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/InternationalizationSettings.ETimezoneSetting")]
	public enum ETimezoneSetting : byte
	{
		// Token: 0x0400ACEA RID: 44266
		InternationalDateLineWest,
		// Token: 0x0400ACEB RID: 44267
		CoordinatedUniversalTimeNeg11,
		// Token: 0x0400ACEC RID: 44268
		Samoa,
		// Token: 0x0400ACED RID: 44269
		Hawaii,
		// Token: 0x0400ACEE RID: 44270
		Alaska,
		// Token: 0x0400ACEF RID: 44271
		PacificTime_USCAN,
		// Token: 0x0400ACF0 RID: 44272
		BajaCalifornia,
		// Token: 0x0400ACF1 RID: 44273
		MountainTime_USCAN,
		// Token: 0x0400ACF2 RID: 44274
		Chihuahua_LaPaz_Mazatlan,
		// Token: 0x0400ACF3 RID: 44275
		Arizona,
		// Token: 0x0400ACF4 RID: 44276
		Saskatchewan,
		// Token: 0x0400ACF5 RID: 44277
		CentralAmerica,
		// Token: 0x0400ACF6 RID: 44278
		CentralTime_USCAN,
		// Token: 0x0400ACF7 RID: 44279
		Guadalajara_MexicoCity_Monterrey,
		// Token: 0x0400ACF8 RID: 44280
		EasternTime_USCAN,
		// Token: 0x0400ACF9 RID: 44281
		Bogota_Lima_Quito,
		// Token: 0x0400ACFA RID: 44282
		Indiana_US,
		// Token: 0x0400ACFB RID: 44283
		Caracas,
		// Token: 0x0400ACFC RID: 44284
		AtlanticTime_Canada,
		// Token: 0x0400ACFD RID: 44285
		Cuiaba,
		// Token: 0x0400ACFE RID: 44286
		Santiago,
		// Token: 0x0400ACFF RID: 44287
		Georgetown_LaPaz_Manaus_SanJuan,
		// Token: 0x0400AD00 RID: 44288
		Asuncion,
		// Token: 0x0400AD01 RID: 44289
		Newfoundland,
		// Token: 0x0400AD02 RID: 44290
		Brasilia,
		// Token: 0x0400AD03 RID: 44291
		Greenland,
		// Token: 0x0400AD04 RID: 44292
		Montevideo,
		// Token: 0x0400AD05 RID: 44293
		Cayenne_Fortaleza,
		// Token: 0x0400AD06 RID: 44294
		BuenosAires,
		// Token: 0x0400AD07 RID: 44295
		MidAtlantic,
		// Token: 0x0400AD08 RID: 44296
		CoordinatedUniversalTimeNeg02,
		// Token: 0x0400AD09 RID: 44297
		Azores,
		// Token: 0x0400AD0A RID: 44298
		CaboVerdeIs,
		// Token: 0x0400AD0B RID: 44299
		Dublin_Edinburgh_Lisbon_London,
		// Token: 0x0400AD0C RID: 44300
		Monrovia_Reykjavik,
		// Token: 0x0400AD0D RID: 44301
		Casablanca,
		// Token: 0x0400AD0E RID: 44302
		UTC,
		// Token: 0x0400AD0F RID: 44303
		Belgrade_Bratislava_Budapest_Ljubljana_Prague,
		// Token: 0x0400AD10 RID: 44304
		Sarajevo_Skopje_Warsaw_Zagreb,
		// Token: 0x0400AD11 RID: 44305
		Brussels_Copenhagen_Madrid_Paris,
		// Token: 0x0400AD12 RID: 44306
		WestCentralAfrica,
		// Token: 0x0400AD13 RID: 44307
		Amsterdam_Berlin_Bern_Rome_Stockholm_Vienna,
		// Token: 0x0400AD14 RID: 44308
		Windhoek,
		// Token: 0x0400AD15 RID: 44309
		Minsk,
		// Token: 0x0400AD16 RID: 44310
		Cairo,
		// Token: 0x0400AD17 RID: 44311
		Helsinki_Kyiv_Riga_Sofia_Tallinn_Vilnius,
		// Token: 0x0400AD18 RID: 44312
		Athens_Bucharest,
		// Token: 0x0400AD19 RID: 44313
		Jerusalem,
		// Token: 0x0400AD1A RID: 44314
		Amman,
		// Token: 0x0400AD1B RID: 44315
		Beirut,
		// Token: 0x0400AD1C RID: 44316
		Harare_Pretoria,
		// Token: 0x0400AD1D RID: 44317
		Damascus,
		// Token: 0x0400AD1E RID: 44318
		Istanbul,
		// Token: 0x0400AD1F RID: 44319
		Kuwait_Riyadh,
		// Token: 0x0400AD20 RID: 44320
		Baghdad,
		// Token: 0x0400AD21 RID: 44321
		Nairobi,
		// Token: 0x0400AD22 RID: 44322
		Kaliningrad,
		// Token: 0x0400AD23 RID: 44323
		Tehran,
		// Token: 0x0400AD24 RID: 44324
		Moscow_StPetersburg_Volgograd,
		// Token: 0x0400AD25 RID: 44325
		AbuDhabi_Muscat,
		// Token: 0x0400AD26 RID: 44326
		Baku,
		// Token: 0x0400AD27 RID: 44327
		Yerevan,
		// Token: 0x0400AD28 RID: 44328
		Tbilisi,
		// Token: 0x0400AD29 RID: 44329
		PortLouis,
		// Token: 0x0400AD2A RID: 44330
		Kabul,
		// Token: 0x0400AD2B RID: 44331
		Tashkent,
		// Token: 0x0400AD2C RID: 44332
		Islamabad_Karachi,
		// Token: 0x0400AD2D RID: 44333
		Chennai_Kolkata_Mumbai_NewDelhi,
		// Token: 0x0400AD2E RID: 44334
		SriJayawardenepura,
		// Token: 0x0400AD2F RID: 44335
		Kathmandu,
		// Token: 0x0400AD30 RID: 44336
		Ekaterinburg,
		// Token: 0x0400AD31 RID: 44337
		Astana,
		// Token: 0x0400AD32 RID: 44338
		Dhaka,
		// Token: 0x0400AD33 RID: 44339
		Yangon_Rangoon,
		// Token: 0x0400AD34 RID: 44340
		Novosibirsk,
		// Token: 0x0400AD35 RID: 44341
		Bangkok_Hanoi_Jakarta,
		// Token: 0x0400AD36 RID: 44342
		Krasnoyarsk,
		// Token: 0x0400AD37 RID: 44343
		Beijing_Chongqing_HongKong_Urumqi,
		// Token: 0x0400AD38 RID: 44344
		KualaLumpur_Singapore,
		// Token: 0x0400AD39 RID: 44345
		Taipei,
		// Token: 0x0400AD3A RID: 44346
		Perth,
		// Token: 0x0400AD3B RID: 44347
		Ulaanbaatar,
		// Token: 0x0400AD3C RID: 44348
		Irkutsk,
		// Token: 0x0400AD3D RID: 44349
		Seoul,
		// Token: 0x0400AD3E RID: 44350
		Osaka_Sapporo_Tokyo,
		// Token: 0x0400AD3F RID: 44351
		Darwin,
		// Token: 0x0400AD40 RID: 44352
		Adelaide,
		// Token: 0x0400AD41 RID: 44353
		Yakutsk,
		// Token: 0x0400AD42 RID: 44354
		Canberra_Melbourne_Sydney,
		// Token: 0x0400AD43 RID: 44355
		Brisbane,
		// Token: 0x0400AD44 RID: 44356
		Hobart,
		// Token: 0x0400AD45 RID: 44357
		Guam_PortMoresby,
		// Token: 0x0400AD46 RID: 44358
		Vladivostok,
		// Token: 0x0400AD47 RID: 44359
		SolomonIs_NewCaledonia,
		// Token: 0x0400AD48 RID: 44360
		Magadan,
		// Token: 0x0400AD49 RID: 44361
		Fiji,
		// Token: 0x0400AD4A RID: 44362
		Auckland_Wellington,
		// Token: 0x0400AD4B RID: 44363
		CoordinatedUniversalTime12,
		// Token: 0x0400AD4C RID: 44364
		Nukualofa,
		// Token: 0x0400AD4D RID: 44365
		LocalTime,
		// Token: 0x0400AD4E RID: 44366
		ETimezoneSetting_MAX
	}
}
