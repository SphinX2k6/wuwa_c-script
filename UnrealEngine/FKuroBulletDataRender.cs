using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020016F7 RID: 5879
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletDataRender")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FKuroBulletDataRender : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060153CD RID: 86989 RVA: 0x001F3728 File Offset: 0x001F1928
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBulletDataRender._ScriptStructPtr != 0) ? FKuroBulletDataRender._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.KuroBulletDataRender", ref FKuroBulletDataRender._ScriptStructPtr);
		}

		// Token: 0x17005401 RID: 21505
		// (get) Token: 0x060153CE RID: 86990 RVA: 0x001F374C File Offset: 0x001F194C
		// (set) Token: 0x060153CF RID: 86991 RVA: 0x001F376B File Offset: 0x001F196B
		public TSoftObjectPtr<UEffectModelBase> EffectBullet
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)FKuroBulletDataRender.__PropertyOffset_EffectBullet, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FKuroBulletDataRender.__PropertyOffset_EffectBullet, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005402 RID: 21506
		// (get) Token: 0x060153D0 RID: 86992 RVA: 0x001F3790 File Offset: 0x001F1990
		// (set) Token: 0x060153D1 RID: 86993 RVA: 0x001F37D3 File Offset: 0x001F19D3
		public TMap<EKuroBulletEffectParam, string> EffectBulletParams
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKuroBulletEffectParam, string> result;
				if ((result = this._EffectBulletParams) == null)
				{
					result = (this._EffectBulletParams = new TMap<EKuroBulletEffectParam, string>(base.NativePtr + (IntPtr)FKuroBulletDataRender.__PropertyOffset_EffectBulletParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EffectBulletParams.CopyAssign(value);
			}
		}

		// Token: 0x17005403 RID: 21507
		// (get) Token: 0x060153D2 RID: 86994 RVA: 0x001F37E1 File Offset: 0x001F19E1
		// (set) Token: 0x060153D3 RID: 86995 RVA: 0x001F37F1 File Offset: 0x001F19F1
		public unsafe bool bNotDestroyEffectImmediately
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataRender.__PropertyOffset_bNotDestroyEffectImmediately) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataRender.__PropertyOffset_bNotDestroyEffectImmediately) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005404 RID: 21508
		// (get) Token: 0x060153D4 RID: 86996 RVA: 0x001F3804 File Offset: 0x001F1A04
		// (set) Token: 0x060153D5 RID: 86997 RVA: 0x001F3847 File Offset: 0x001F1A47
		public TMap<EKuroBulletHitEffect, TSoftObjectPtr<UObject>> EffectOnHit
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKuroBulletHitEffect, TSoftObjectPtr<UObject>> result;
				if ((result = this._EffectOnHit) == null)
				{
					result = (this._EffectOnHit = new TMap<EKuroBulletHitEffect, TSoftObjectPtr<UObject>>(base.NativePtr + (IntPtr)FKuroBulletDataRender.__PropertyOffset_EffectOnHit, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EffectOnHit.CopyAssign(value);
			}
		}

		// Token: 0x17005405 RID: 21509
		// (get) Token: 0x060153D6 RID: 86998 RVA: 0x001F3855 File Offset: 0x001F1A55
		// (set) Token: 0x060153D7 RID: 86999 RVA: 0x001F3865 File Offset: 0x001F1A65
		public unsafe bool bApplyHitMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataRender.__PropertyOffset_bApplyHitMaterial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataRender.__PropertyOffset_bApplyHitMaterial) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005406 RID: 21510
		// (get) Token: 0x060153D8 RID: 87000 RVA: 0x001F3876 File Offset: 0x001F1A76
		// (set) Token: 0x060153D9 RID: 87001 RVA: 0x001F3886 File Offset: 0x001F1A86
		public unsafe int AttackerCameraShakeOnStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataRender.__PropertyOffset_AttackerCameraShakeOnStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataRender.__PropertyOffset_AttackerCameraShakeOnStart) = value;
			}
		}

		// Token: 0x17005407 RID: 21511
		// (get) Token: 0x060153DA RID: 87002 RVA: 0x001F3897 File Offset: 0x001F1A97
		// (set) Token: 0x060153DB RID: 87003 RVA: 0x001F38A7 File Offset: 0x001F1AA7
		public unsafe int AttackerCameraShakeOnHit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataRender.__PropertyOffset_AttackerCameraShakeOnHit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataRender.__PropertyOffset_AttackerCameraShakeOnHit) = value;
			}
		}

		// Token: 0x17005408 RID: 21512
		// (get) Token: 0x060153DC RID: 87004 RVA: 0x001F38B8 File Offset: 0x001F1AB8
		// (set) Token: 0x060153DD RID: 87005 RVA: 0x001F38C8 File Offset: 0x001F1AC8
		public unsafe int VictimCameraShakeOnHit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataRender.__PropertyOffset_VictimCameraShakeOnHit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataRender.__PropertyOffset_VictimCameraShakeOnHit) = value;
			}
		}

		// Token: 0x060153DE RID: 87006 RVA: 0x001F38D9 File Offset: 0x001F1AD9
		public FKuroBulletDataRender()
		{
		}

		// Token: 0x060153DF RID: 87007 RVA: 0x001F38E4 File Offset: 0x001F1AE4
		public FKuroBulletDataRender(TSoftObjectPtr<UEffectModelBase> EffectBullet, TMap<EKuroBulletEffectParam, string> EffectBulletParams, bool bNotDestroyEffectImmediately, TMap<EKuroBulletHitEffect, TSoftObjectPtr<UObject>> EffectOnHit, bool bApplyHitMaterial, int AttackerCameraShakeOnStart, int AttackerCameraShakeOnHit, int VictimCameraShakeOnHit)
		{
			this.EffectBullet = EffectBullet;
			this.EffectBulletParams = EffectBulletParams;
			this.bNotDestroyEffectImmediately = bNotDestroyEffectImmediately;
			this.EffectOnHit = EffectOnHit;
			this.bApplyHitMaterial = bApplyHitMaterial;
			this.AttackerCameraShakeOnStart = AttackerCameraShakeOnStart;
			this.AttackerCameraShakeOnHit = AttackerCameraShakeOnHit;
			this.VictimCameraShakeOnHit = VictimCameraShakeOnHit;
		}

		// Token: 0x060153E0 RID: 87008 RVA: 0x001F3934 File Offset: 0x001F1B34
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBulletDataRender.StaticStruct();
		}

		// Token: 0x060153E1 RID: 87009 RVA: 0x001F3940 File Offset: 0x001F1B40
		[NullableContext(2)]
		public FKuroBulletDataRender(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060153E2 RID: 87010 RVA: 0x001F394A File Offset: 0x001F1B4A
		public FKuroBulletDataRender(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060153E3 RID: 87011 RVA: 0x001F3955 File Offset: 0x001F1B55
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBulletDataRender(Pointer, false, true);
		}

		// Token: 0x060153E4 RID: 87012 RVA: 0x001F395F File Offset: 0x001F1B5F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBulletDataRender(Pointer, MemoryOwner);
		}

		// Token: 0x0400B949 RID: 47433
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletDataRender";

		// Token: 0x0400B94A RID: 47434
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B94B RID: 47435
		internal static int __PropertyOffset_EffectBullet;

		// Token: 0x0400B94C RID: 47436
		internal static int __PropertyOffset_EffectBulletParams;

		// Token: 0x0400B94D RID: 47437
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EKuroBulletEffectParam, string> _EffectBulletParams;

		// Token: 0x0400B94E RID: 47438
		internal static int __PropertyOffset_bNotDestroyEffectImmediately;

		// Token: 0x0400B94F RID: 47439
		internal static int __PropertyOffset_EffectOnHit;

		// Token: 0x0400B950 RID: 47440
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<EKuroBulletHitEffect, TSoftObjectPtr<UObject>> _EffectOnHit;

		// Token: 0x0400B951 RID: 47441
		internal static int __PropertyOffset_bApplyHitMaterial;

		// Token: 0x0400B952 RID: 47442
		internal static int __PropertyOffset_AttackerCameraShakeOnStart;

		// Token: 0x0400B953 RID: 47443
		internal static int __PropertyOffset_AttackerCameraShakeOnHit;

		// Token: 0x0400B954 RID: 47444
		internal static int __PropertyOffset_VictimCameraShakeOnHit;
	}
}
