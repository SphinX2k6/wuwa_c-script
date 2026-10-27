using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019E3 RID: 6627
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroMovement.KuroMoveBrushTrigger")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class AKuroMoveBrushTrigger : AKuroMoveTrigger, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018977 RID: 100727 RVA: 0x0024369F File Offset: 0x0024189F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroMoveBrushTrigger._ClassPtr;
		}

		// Token: 0x06018978 RID: 100728 RVA: 0x002436AC File Offset: 0x002418AC
		public AKuroMoveBrushTrigger() : this(BuiltinUtils.AllocNativeUObject(AKuroMoveBrushTrigger.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018979 RID: 100729 RVA: 0x002436D4 File Offset: 0x002418D4
		[NullableContext(1)]
		public AKuroMoveBrushTrigger(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroMoveBrushTrigger.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170061F0 RID: 25072
		// (get) Token: 0x0601897A RID: 100730 RVA: 0x00243707 File Offset: 0x00241907
		// (set) Token: 0x0601897B RID: 100731 RVA: 0x0024371B File Offset: 0x0024191B
		public unsafe ABrush Volume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ABrush>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroMoveBrushTrigger.__PropertyOffset_Volume);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroMoveBrushTrigger.__PropertyOffset_Volume, value);
			}
		}

		// Token: 0x170061F1 RID: 25073
		// (get) Token: 0x0601897C RID: 100732 RVA: 0x00243730 File Offset: 0x00241930
		// (set) Token: 0x0601897D RID: 100733 RVA: 0x00243744 File Offset: 0x00241944
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroMoveBrushTrigger.__PropertyOffset_Root);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroMoveBrushTrigger.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x0601897E RID: 100734 RVA: 0x00243759 File Offset: 0x00241959
		static AKuroMoveBrushTrigger()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMovement.KuroMoveBrushTrigger");
		}

		// Token: 0x0601897F RID: 100735 RVA: 0x00243767 File Offset: 0x00241967
		protected AKuroMoveBrushTrigger(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D4A8 RID: 54440
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroMovement.KuroMoveBrushTrigger";

		// Token: 0x0400D4A9 RID: 54441
		private static IntPtr _ClassPtr;

		// Token: 0x0400D4AA RID: 54442
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D4AB RID: 54443
		internal static int __PropertyOffset_Volume;

		// Token: 0x0400D4AC RID: 54444
		internal static int __PropertyOffset_Root;
	}
}
