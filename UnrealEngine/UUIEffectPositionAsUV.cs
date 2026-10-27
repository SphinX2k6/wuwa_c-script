using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200214C RID: 8524
	[UnrealObjectPath("/Script/LGUI.UIEffectPositionAsUV")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UUIEffectPositionAsUV : UUIGeometryModifierBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020241 RID: 131649 RVA: 0x002FC58B File Offset: 0x002FA78B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectPositionAsUV._ClassPtr;
		}

		// Token: 0x06020242 RID: 131650 RVA: 0x002FC598 File Offset: 0x002FA798
		public UUIEffectPositionAsUV() : this(BuiltinUtils.AllocNativeUObject(UUIEffectPositionAsUV.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020243 RID: 131651 RVA: 0x002FC5C0 File Offset: 0x002FA7C0
		[NullableContext(1)]
		public UUIEffectPositionAsUV(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectPositionAsUV.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E2D RID: 32301
		// (get) Token: 0x06020244 RID: 131652 RVA: 0x002FC5F3 File Offset: 0x002FA7F3
		// (set) Token: 0x06020245 RID: 131653 RVA: 0x002FC603 File Offset: 0x002FA803
		public unsafe byte uvChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectPositionAsUV.__PropertyOffset_uvChannel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectPositionAsUV.__PropertyOffset_uvChannel) = value;
			}
		}

		// Token: 0x06020246 RID: 131654 RVA: 0x002FC614 File Offset: 0x002FA814
		static UUIEffectPositionAsUV()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectPositionAsUV");
		}

		// Token: 0x06020247 RID: 131655 RVA: 0x002FC622 File Offset: 0x002FA822
		protected UUIEffectPositionAsUV(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401149E RID: 70814
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectPositionAsUV";

		// Token: 0x0401149F RID: 70815
		private static IntPtr _ClassPtr;

		// Token: 0x040114A0 RID: 70816
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040114A1 RID: 70817
		internal static int __PropertyOffset_uvChannel;
	}
}
