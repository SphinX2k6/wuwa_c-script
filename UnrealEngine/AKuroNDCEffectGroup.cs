using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002517 RID: 9495
	[UnrealObjectPath("/Script/Niagara.KuroNDCEffectGroup")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class AKuroNDCEffectGroup : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602348B RID: 144523 RVA: 0x00342FB0 File Offset: 0x003411B0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroNDCEffectGroup._ClassPtr;
		}

		// Token: 0x0602348C RID: 144524 RVA: 0x00342FBC File Offset: 0x003411BC
		public AKuroNDCEffectGroup() : this(BuiltinUtils.AllocNativeUObject(AKuroNDCEffectGroup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602348D RID: 144525 RVA: 0x00342FE4 File Offset: 0x003411E4
		[NullableContext(1)]
		public AKuroNDCEffectGroup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroNDCEffectGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170087BB RID: 34747
		// (get) Token: 0x0602348E RID: 144526 RVA: 0x00343017 File Offset: 0x00341217
		// (set) Token: 0x0602348F RID: 144527 RVA: 0x00343027 File Offset: 0x00341227
		public unsafe bool bDrawDebugBound
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroNDCEffectGroup.__PropertyOffset_bDrawDebugBound) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroNDCEffectGroup.__PropertyOffset_bDrawDebugBound) = (value ? 1 : 0);
			}
		}

		// Token: 0x170087BC RID: 34748
		// (get) Token: 0x06023490 RID: 144528 RVA: 0x00343038 File Offset: 0x00341238
		// (set) Token: 0x06023491 RID: 144529 RVA: 0x0034304C File Offset: 0x0034124C
		public unsafe FLinearColor DrawDebugSelfCollisionColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroNDCEffectGroup.__PropertyOffset_DrawDebugSelfCollisionColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroNDCEffectGroup.__PropertyOffset_DrawDebugSelfCollisionColor) = value;
			}
		}

		// Token: 0x170087BD RID: 34749
		// (get) Token: 0x06023492 RID: 144530 RVA: 0x00343061 File Offset: 0x00341261
		// (set) Token: 0x06023493 RID: 144531 RVA: 0x00343075 File Offset: 0x00341275
		[Nullable(2)]
		public unsafe USceneComponent SceneComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroNDCEffectGroup.__PropertyOffset_SceneComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroNDCEffectGroup.__PropertyOffset_SceneComponent, value);
			}
		}

		// Token: 0x06023494 RID: 144532 RVA: 0x0034308A File Offset: 0x0034128A
		static AKuroNDCEffectGroup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.KuroNDCEffectGroup");
		}

		// Token: 0x06023495 RID: 144533 RVA: 0x00343098 File Offset: 0x00341298
		protected AKuroNDCEffectGroup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012F12 RID: 77586
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.KuroNDCEffectGroup";

		// Token: 0x04012F13 RID: 77587
		private static IntPtr _ClassPtr;

		// Token: 0x04012F14 RID: 77588
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012F15 RID: 77589
		internal static int __PropertyOffset_bDrawDebugBound;

		// Token: 0x04012F16 RID: 77590
		internal static int __PropertyOffset_DrawDebugSelfCollisionColor;

		// Token: 0x04012F17 RID: 77591
		internal static int __PropertyOffset_SceneComponent;
	}
}
