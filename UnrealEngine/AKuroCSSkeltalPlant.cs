using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017CC RID: 6092
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSSkeltalPlant")]
	[UnrealStructLayout(1216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1216)]
	public class AKuroCSSkeltalPlant : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060165C2 RID: 91586 RVA: 0x0020B0DF File Offset: 0x002092DF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCSSkeltalPlant._ClassPtr;
		}

		// Token: 0x060165C3 RID: 91587 RVA: 0x0020B0EC File Offset: 0x002092EC
		public AKuroCSSkeltalPlant() : this(BuiltinUtils.AllocNativeUObject(AKuroCSSkeltalPlant.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060165C4 RID: 91588 RVA: 0x0020B114 File Offset: 0x00209314
		public AKuroCSSkeltalPlant(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCSSkeltalPlant.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170059ED RID: 23021
		// (get) Token: 0x060165C5 RID: 91589 RVA: 0x0020B147 File Offset: 0x00209347
		// (set) Token: 0x060165C6 RID: 91590 RVA: 0x0020B15B File Offset: 0x0020935B
		[Nullable(2)]
		public unsafe USceneComponent Root
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSkeltalPlant.__PropertyOffset_Root);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSkeltalPlant.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x170059EE RID: 23022
		// (get) Token: 0x060165C7 RID: 91591 RVA: 0x0020B170 File Offset: 0x00209370
		// (set) Token: 0x060165C8 RID: 91592 RVA: 0x0020B180 File Offset: 0x00209380
		public unsafe int ParticleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_ParticleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_ParticleCount) = value;
			}
		}

		// Token: 0x170059EF RID: 23023
		// (get) Token: 0x060165C9 RID: 91593 RVA: 0x0020B194 File Offset: 0x00209394
		// (set) Token: 0x060165CA RID: 91594 RVA: 0x0020B1CD File Offset: 0x002093CD
		public TArray<int> ParentIDList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ParentIDList) == null)
				{
					result = (this._ParentIDList = new TArray<int>(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_ParentIDList, this));
				}
				return result;
			}
			set
			{
				this.ParentIDList.CopyAssign(value);
			}
		}

		// Token: 0x170059F0 RID: 23024
		// (get) Token: 0x060165CB RID: 91595 RVA: 0x0020B1DC File Offset: 0x002093DC
		// (set) Token: 0x060165CC RID: 91596 RVA: 0x0020B215 File Offset: 0x00209415
		public TArray<int> ChildIDList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ChildIDList) == null)
				{
					result = (this._ChildIDList = new TArray<int>(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_ChildIDList, this));
				}
				return result;
			}
			set
			{
				this.ChildIDList.CopyAssign(value);
			}
		}

		// Token: 0x170059F1 RID: 23025
		// (get) Token: 0x060165CD RID: 91597 RVA: 0x0020B224 File Offset: 0x00209424
		// (set) Token: 0x060165CE RID: 91598 RVA: 0x0020B25D File Offset: 0x0020945D
		public TArray<FVector> PosList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._PosList) == null)
				{
					result = (this._PosList = new TArray<FVector>(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_PosList, this));
				}
				return result;
			}
			set
			{
				this.PosList.CopyAssign(value);
			}
		}

		// Token: 0x170059F2 RID: 23026
		// (get) Token: 0x060165CF RID: 91599 RVA: 0x0020B26C File Offset: 0x0020946C
		// (set) Token: 0x060165D0 RID: 91600 RVA: 0x0020B2A5 File Offset: 0x002094A5
		public TArray<FQuat> QuatList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FQuat> result;
				if ((result = this._QuatList) == null)
				{
					result = (this._QuatList = new TArray<FQuat>(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_QuatList, this));
				}
				return result;
			}
			set
			{
				this.QuatList.CopyAssign(value);
			}
		}

		// Token: 0x170059F3 RID: 23027
		// (get) Token: 0x060165D1 RID: 91601 RVA: 0x0020B2B4 File Offset: 0x002094B4
		// (set) Token: 0x060165D2 RID: 91602 RVA: 0x0020B2ED File Offset: 0x002094ED
		public TArray<float> BoneMaskList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._BoneMaskList) == null)
				{
					result = (this._BoneMaskList = new TArray<float>(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_BoneMaskList, this));
				}
				return result;
			}
			set
			{
				this.BoneMaskList.CopyAssign(value);
			}
		}

		// Token: 0x170059F4 RID: 23028
		// (get) Token: 0x060165D3 RID: 91603 RVA: 0x0020B2FB File Offset: 0x002094FB
		// (set) Token: 0x060165D4 RID: 91604 RVA: 0x0020B30B File Offset: 0x0020950B
		public unsafe bool SpringMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_SpringMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_SpringMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x170059F5 RID: 23029
		// (get) Token: 0x060165D5 RID: 91605 RVA: 0x0020B31C File Offset: 0x0020951C
		// (set) Token: 0x060165D6 RID: 91606 RVA: 0x0020B32C File Offset: 0x0020952C
		public unsafe float TickTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_TickTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_TickTime) = value;
			}
		}

		// Token: 0x170059F6 RID: 23030
		// (get) Token: 0x060165D7 RID: 91607 RVA: 0x0020B33D File Offset: 0x0020953D
		// (set) Token: 0x060165D8 RID: 91608 RVA: 0x0020B351 File Offset: 0x00209551
		public unsafe FVector playerPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_playerPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_playerPos) = value;
			}
		}

		// Token: 0x170059F7 RID: 23031
		// (get) Token: 0x060165D9 RID: 91609 RVA: 0x0020B366 File Offset: 0x00209566
		// (set) Token: 0x060165DA RID: 91610 RVA: 0x0020B376 File Offset: 0x00209576
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_collisionR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_collisionR) = value;
			}
		}

		// Token: 0x170059F8 RID: 23032
		// (get) Token: 0x060165DB RID: 91611 RVA: 0x0020B387 File Offset: 0x00209587
		// (set) Token: 0x060165DC RID: 91612 RVA: 0x0020B397 File Offset: 0x00209597
		public unsafe float pushStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_pushStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_pushStrength) = value;
			}
		}

		// Token: 0x170059F9 RID: 23033
		// (get) Token: 0x060165DD RID: 91613 RVA: 0x0020B3A8 File Offset: 0x002095A8
		// (set) Token: 0x060165DE RID: 91614 RVA: 0x0020B3B8 File Offset: 0x002095B8
		public unsafe float AffectChildStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_AffectChildStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_AffectChildStrength) = value;
			}
		}

		// Token: 0x170059FA RID: 23034
		// (get) Token: 0x060165DF RID: 91615 RVA: 0x0020B3C9 File Offset: 0x002095C9
		// (set) Token: 0x060165E0 RID: 91616 RVA: 0x0020B3D9 File Offset: 0x002095D9
		public unsafe float KSpring
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_KSpring);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_KSpring) = value;
			}
		}

		// Token: 0x170059FB RID: 23035
		// (get) Token: 0x060165E1 RID: 91617 RVA: 0x0020B3EA File Offset: 0x002095EA
		// (set) Token: 0x060165E2 RID: 91618 RVA: 0x0020B3FA File Offset: 0x002095FA
		public unsafe float CSpring
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_CSpring);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_CSpring) = value;
			}
		}

		// Token: 0x170059FC RID: 23036
		// (get) Token: 0x060165E3 RID: 91619 RVA: 0x0020B40B File Offset: 0x0020960B
		// (set) Token: 0x060165E4 RID: 91620 RVA: 0x0020B41F File Offset: 0x0020961F
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSkeltalPlant.__PropertyOffset_RenderTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSSkeltalPlant.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x170059FD RID: 23037
		// (get) Token: 0x060165E5 RID: 91621 RVA: 0x0020B434 File Offset: 0x00209634
		// (set) Token: 0x060165E6 RID: 91622 RVA: 0x0020B444 File Offset: 0x00209644
		public unsafe bool AllowDebugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_AllowDebugDraw) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_AllowDebugDraw) = (value ? 1 : 0);
			}
		}

		// Token: 0x170059FE RID: 23038
		// (get) Token: 0x060165E7 RID: 91623 RVA: 0x0020B458 File Offset: 0x00209658
		// (set) Token: 0x060165E8 RID: 91624 RVA: 0x0020B491 File Offset: 0x00209691
		public TArray<FKuroCSParticle_skelPlant> DebugArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_skelPlant> result;
				if ((result = this._DebugArr) == null)
				{
					result = (this._DebugArr = new TArray<FKuroCSParticle_skelPlant>(base.NativePtr + (IntPtr)AKuroCSSkeltalPlant.__PropertyOffset_DebugArr, this));
				}
				return result;
			}
			set
			{
				this.DebugArr.CopyAssign(value);
			}
		}

		// Token: 0x060165E9 RID: 91625 RVA: 0x0020B49F File Offset: 0x0020969F
		public void StopSimulation()
		{
			AKuroCSSkeltalPlant.__StopSimulation_Internal(base.NativePtr);
		}

		// Token: 0x060165EA RID: 91626 RVA: 0x0020B4AC File Offset: 0x002096AC
		public void StartSimulation()
		{
			AKuroCSSkeltalPlant.__StartSimulation_Internal(base.NativePtr);
		}

		// Token: 0x060165EB RID: 91627 RVA: 0x0020B4B9 File Offset: 0x002096B9
		public void ReleaseShaderManager()
		{
			AKuroCSSkeltalPlant.__ReleaseShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x060165EC RID: 91628 RVA: 0x0020B4C6 File Offset: 0x002096C6
		public void InitShaderManager()
		{
			AKuroCSSkeltalPlant.__InitShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x060165ED RID: 91629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSimulation_Internal(IntPtr @this);

		// Token: 0x060165EE RID: 91630
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSimulation_Internal(IntPtr @this);

		// Token: 0x060165EF RID: 91631
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReleaseShaderManager_Internal(IntPtr @this);

		// Token: 0x060165F0 RID: 91632
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitShaderManager_Internal(IntPtr @this);

		// Token: 0x060165F1 RID: 91633 RVA: 0x0020B4D3 File Offset: 0x002096D3
		static AKuroCSSkeltalPlant()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCSSkeltalPlant");
		}

		// Token: 0x060165F2 RID: 91634 RVA: 0x0020B4E1 File Offset: 0x002096E1
		protected AKuroCSSkeltalPlant(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C27B RID: 49787
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCSSkeltalPlant";

		// Token: 0x0400C27C RID: 49788
		private static IntPtr _ClassPtr;

		// Token: 0x0400C27D RID: 49789
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C27E RID: 49790
		internal static int __PropertyOffset_Root;

		// Token: 0x0400C27F RID: 49791
		internal static int __PropertyOffset_ParticleCount;

		// Token: 0x0400C280 RID: 49792
		internal static int __PropertyOffset_ParentIDList;

		// Token: 0x0400C281 RID: 49793
		[Nullable(2)]
		private TArray<int> _ParentIDList;

		// Token: 0x0400C282 RID: 49794
		internal static int __PropertyOffset_ChildIDList;

		// Token: 0x0400C283 RID: 49795
		[Nullable(2)]
		private TArray<int> _ChildIDList;

		// Token: 0x0400C284 RID: 49796
		internal static int __PropertyOffset_PosList;

		// Token: 0x0400C285 RID: 49797
		[Nullable(2)]
		private TArray<FVector> _PosList;

		// Token: 0x0400C286 RID: 49798
		internal static int __PropertyOffset_QuatList;

		// Token: 0x0400C287 RID: 49799
		[Nullable(2)]
		private TArray<FQuat> _QuatList;

		// Token: 0x0400C288 RID: 49800
		internal static int __PropertyOffset_BoneMaskList;

		// Token: 0x0400C289 RID: 49801
		[Nullable(2)]
		private TArray<float> _BoneMaskList;

		// Token: 0x0400C28A RID: 49802
		internal static int __PropertyOffset_SpringMode;

		// Token: 0x0400C28B RID: 49803
		internal static int __PropertyOffset_TickTime;

		// Token: 0x0400C28C RID: 49804
		internal static int __PropertyOffset_playerPos;

		// Token: 0x0400C28D RID: 49805
		internal static int __PropertyOffset_collisionR;

		// Token: 0x0400C28E RID: 49806
		internal static int __PropertyOffset_pushStrength;

		// Token: 0x0400C28F RID: 49807
		internal static int __PropertyOffset_AffectChildStrength;

		// Token: 0x0400C290 RID: 49808
		internal static int __PropertyOffset_KSpring;

		// Token: 0x0400C291 RID: 49809
		internal static int __PropertyOffset_CSpring;

		// Token: 0x0400C292 RID: 49810
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x0400C293 RID: 49811
		internal static int __PropertyOffset_AllowDebugDraw;

		// Token: 0x0400C294 RID: 49812
		internal static int __PropertyOffset_DebugArr;

		// Token: 0x0400C295 RID: 49813
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_skelPlant> _DebugArr;
	}
}
