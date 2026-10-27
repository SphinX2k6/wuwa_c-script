using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000279 RID: 633
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.EAkMidiCcValues")]
	public enum EAkMidiCcValues : byte
	{
		// Token: 0x04000D10 RID: 3344
		AkMidiCcBankSelectCoarse,
		// Token: 0x04000D11 RID: 3345
		AkMidiCcModWheelCoarse,
		// Token: 0x04000D12 RID: 3346
		AkMidiCcBreathCtrlCoarse,
		// Token: 0x04000D13 RID: 3347
		AkMidiCcCtrl3Coarse,
		// Token: 0x04000D14 RID: 3348
		AkMidiCcFootPedalCoarse,
		// Token: 0x04000D15 RID: 3349
		AkMidiCcPortamentoCoarse,
		// Token: 0x04000D16 RID: 3350
		AkMidiCcDataEntryCoarse,
		// Token: 0x04000D17 RID: 3351
		AkMidiCcVolumeCoarse,
		// Token: 0x04000D18 RID: 3352
		AkMidiCcBalanceCoarse,
		// Token: 0x04000D19 RID: 3353
		AkMidiCcCtrl9Coarse,
		// Token: 0x04000D1A RID: 3354
		AkMidiCcPanPositionCoarse,
		// Token: 0x04000D1B RID: 3355
		AkMidiCcExpressionCoarse,
		// Token: 0x04000D1C RID: 3356
		AkMidiCcEffectCtrl1Coarse,
		// Token: 0x04000D1D RID: 3357
		AkMidiCcEffectCtrl2Coarse,
		// Token: 0x04000D1E RID: 3358
		AkMidiCcCtrl14Coarse,
		// Token: 0x04000D1F RID: 3359
		AkMidiCcCtrl15Coarse,
		// Token: 0x04000D20 RID: 3360
		AkMidiCcGenSlider1,
		// Token: 0x04000D21 RID: 3361
		AkMidiCcGenSlider2,
		// Token: 0x04000D22 RID: 3362
		AkMidiCcGenSlider3,
		// Token: 0x04000D23 RID: 3363
		AkMidiCcGenSlider4,
		// Token: 0x04000D24 RID: 3364
		AkMidiCcCtrl20Coarse,
		// Token: 0x04000D25 RID: 3365
		AkMidiCcCtrl21Coarse,
		// Token: 0x04000D26 RID: 3366
		AkMidiCcCtrl22Coarse,
		// Token: 0x04000D27 RID: 3367
		AkMidiCcCtrl23Coarse,
		// Token: 0x04000D28 RID: 3368
		AkMidiCcCtrl24Coarse,
		// Token: 0x04000D29 RID: 3369
		AkMidiCcCtrl25Coarse,
		// Token: 0x04000D2A RID: 3370
		AkMidiCcCtrl26Coarse,
		// Token: 0x04000D2B RID: 3371
		AkMidiCcCtrl27Coarse,
		// Token: 0x04000D2C RID: 3372
		AkMidiCcCtrl28Coarse,
		// Token: 0x04000D2D RID: 3373
		AkMidiCcCtrl29Coarse,
		// Token: 0x04000D2E RID: 3374
		AkMidiCcCtrl30Coarse,
		// Token: 0x04000D2F RID: 3375
		AkMidiCcCtrl31Coarse,
		// Token: 0x04000D30 RID: 3376
		AkMidiCcBankSelectFine,
		// Token: 0x04000D31 RID: 3377
		AkMidiCcModWheelFine,
		// Token: 0x04000D32 RID: 3378
		AkMidiCcBreathCtrlFine,
		// Token: 0x04000D33 RID: 3379
		AkMidiCcCtrl3Fine,
		// Token: 0x04000D34 RID: 3380
		AkMidiCcFootPedalFine,
		// Token: 0x04000D35 RID: 3381
		AkMidiCcPortamentoFine,
		// Token: 0x04000D36 RID: 3382
		AkMidiCcDataEntryFine,
		// Token: 0x04000D37 RID: 3383
		AkMidiCcVolumeFine,
		// Token: 0x04000D38 RID: 3384
		AkMidiCcBalanceFine,
		// Token: 0x04000D39 RID: 3385
		AkMidiCcCtrl9Fine,
		// Token: 0x04000D3A RID: 3386
		AkMidiCcPanPositionFine,
		// Token: 0x04000D3B RID: 3387
		AkMidiCcExpressionFine,
		// Token: 0x04000D3C RID: 3388
		AkMidiCcEffectCtrl1Fine,
		// Token: 0x04000D3D RID: 3389
		AkMidiCcEffectCtrl2Fine,
		// Token: 0x04000D3E RID: 3390
		AkMidiCcCtrl14Fine,
		// Token: 0x04000D3F RID: 3391
		AkMidiCcCtrl15Fine,
		// Token: 0x04000D40 RID: 3392
		AkMidiCcCtrl20Fine = 52,
		// Token: 0x04000D41 RID: 3393
		AkMidiCcCtrl21Fine,
		// Token: 0x04000D42 RID: 3394
		AkMidiCcCtrl22Fine,
		// Token: 0x04000D43 RID: 3395
		AkMidiCcCtrl23Fine,
		// Token: 0x04000D44 RID: 3396
		AkMidiCcCtrl24Fine,
		// Token: 0x04000D45 RID: 3397
		AkMidiCcCtrl25Fine,
		// Token: 0x04000D46 RID: 3398
		AkMidiCcCtrl26Fine,
		// Token: 0x04000D47 RID: 3399
		AkMidiCcCtrl27Fine,
		// Token: 0x04000D48 RID: 3400
		AkMidiCcCtrl28Fine,
		// Token: 0x04000D49 RID: 3401
		AkMidiCcCtrl29Fine,
		// Token: 0x04000D4A RID: 3402
		AkMidiCcCtrl30Fine,
		// Token: 0x04000D4B RID: 3403
		AkMidiCcCtrl31Fine,
		// Token: 0x04000D4C RID: 3404
		AkMidiCcHoldPedal,
		// Token: 0x04000D4D RID: 3405
		AkMidiCcPortamentoOnOff,
		// Token: 0x04000D4E RID: 3406
		AkMidiCcSustenutoPedal,
		// Token: 0x04000D4F RID: 3407
		AkMidiCcSoftPedal,
		// Token: 0x04000D50 RID: 3408
		AkMidiCcLegatoPedal,
		// Token: 0x04000D51 RID: 3409
		AkMidiCcHoldPedal2,
		// Token: 0x04000D52 RID: 3410
		AkMidiCcSoundVariation,
		// Token: 0x04000D53 RID: 3411
		AkMidiCcSoundTimbre,
		// Token: 0x04000D54 RID: 3412
		AkMidiCcSoundReleaseTime,
		// Token: 0x04000D55 RID: 3413
		AkMidiCcSoundAttackTime,
		// Token: 0x04000D56 RID: 3414
		AkMidiCcSoundBrightness,
		// Token: 0x04000D57 RID: 3415
		AkMidiCcSoundCtrl6,
		// Token: 0x04000D58 RID: 3416
		AkMidiCcSoundCtrl7,
		// Token: 0x04000D59 RID: 3417
		AkMidiCcSoundCtrl8,
		// Token: 0x04000D5A RID: 3418
		AkMidiCcSoundCtrl9,
		// Token: 0x04000D5B RID: 3419
		AkMidiCcSoundCtrl10,
		// Token: 0x04000D5C RID: 3420
		AkMidiCcGeneralButton1,
		// Token: 0x04000D5D RID: 3421
		AkMidiCcGeneralButton2,
		// Token: 0x04000D5E RID: 3422
		AkMidiCcGeneralButton3,
		// Token: 0x04000D5F RID: 3423
		AkMidiCcGeneralButton4,
		// Token: 0x04000D60 RID: 3424
		AkMidiCcReverbLevel = 91,
		// Token: 0x04000D61 RID: 3425
		AkMidiCcTremoloLevel,
		// Token: 0x04000D62 RID: 3426
		AkMidiCcChorusLevel,
		// Token: 0x04000D63 RID: 3427
		AkMidiCcCelesteLevel,
		// Token: 0x04000D64 RID: 3428
		AkMidiCcPhaserLevel,
		// Token: 0x04000D65 RID: 3429
		AkMidiCcDataButtonP1,
		// Token: 0x04000D66 RID: 3430
		AkMidiCcDataButtonM1,
		// Token: 0x04000D67 RID: 3431
		AkMidiCcNonRegisterCoarse,
		// Token: 0x04000D68 RID: 3432
		AkMidiCcNonRegisterFine,
		// Token: 0x04000D69 RID: 3433
		AkMidiCcAllSoundOff = 120,
		// Token: 0x04000D6A RID: 3434
		AkMidiCcAllControllersOff,
		// Token: 0x04000D6B RID: 3435
		AkMidiCcLocalKeyboard,
		// Token: 0x04000D6C RID: 3436
		AkMidiCcAllNotesOff,
		// Token: 0x04000D6D RID: 3437
		AkMidiCcOmniModeOff,
		// Token: 0x04000D6E RID: 3438
		AkMidiCcOmniModeOn,
		// Token: 0x04000D6F RID: 3439
		AkMidiCcOmniMonophonicOn,
		// Token: 0x04000D70 RID: 3440
		AkMidiCcOmniPolyphonicOn,
		// Token: 0x04000D71 RID: 3441
		EAkMidiCcValues_MAX
	}
}
