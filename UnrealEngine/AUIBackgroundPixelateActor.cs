using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200212B RID: 8491
	[UnrealObjectPath("/Script/LGUI.UIBackgroundPixelateActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AUIBackgroundPixelateActor : AUIPostProcessBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FF22 RID: 130850 RVA: 0x002F8256 File Offset: 0x002F6456
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUIBackgroundPixelateActor._ClassPtr;
		}

		// Token: 0x0601FF23 RID: 130851 RVA: 0x002F8264 File Offset: 0x002F6464
		public AUIBackgroundPixelateActor() : this(BuiltinUtils.AllocNativeUObject(AUIBackgroundPixelateActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FF24 RID: 130852 RVA: 0x002F828C File Offset: 0x002F648C
		[NullableContext(1)]
		public AUIBackgroundPixelateActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUIBackgroundPixelateActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007D8F RID: 32143
		// (get) Token: 0x0601FF25 RID: 130853 RVA: 0x002F82BF File Offset: 0x002F64BF
		// (set) Token: 0x0601FF26 RID: 130854 RVA: 0x002F82D3 File Offset: 0x002F64D3
		[Nullable(2)]
		public unsafe UUIBackgroundPixelate UIBackgroundPixelate
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIBackgroundPixelate>(base.NativePtr / (IntPtr)sizeof(void*) + AUIBackgroundPixelateActor.__PropertyOffset_UIBackgroundPixelate);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AUIBackgroundPixelateActor.__PropertyOffset_UIBackgroundPixelate, value);
			}
		}

		// Token: 0x0601FF27 RID: 130855 RVA: 0x002F82E8 File Offset: 0x002F64E8
		static AUIBackgroundPixelateActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIBackgroundPixelateActor");
		}

		// Token: 0x0601FF28 RID: 130856 RVA: 0x002F82F6 File Offset: 0x002F64F6
		protected AUIBackgroundPixelateActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401134E RID: 70478
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIBackgroundPixelateActor";

		// Token: 0x0401134F RID: 70479
		private static IntPtr _ClassPtr;

		// Token: 0x04011350 RID: 70480
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011351 RID: 70481
		internal static int __PropertyOffset_UIBackgroundPixelate;
	}
}
