using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001074 RID: 4212
	[UnrealObjectPath("/Script/Engine.RectLight")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class ARectLight : ALight, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600EFA7 RID: 61351 RVA: 0x00163605 File Offset: 0x00161805
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ARectLight._ClassPtr;
		}

		// Token: 0x0600EFA8 RID: 61352 RVA: 0x00163614 File Offset: 0x00161814
		public ARectLight() : this(BuiltinUtils.AllocNativeUObject(ARectLight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600EFA9 RID: 61353 RVA: 0x0016363C File Offset: 0x0016183C
		[NullableContext(1)]
		public ARectLight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ARectLight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003A01 RID: 14849
		// (get) Token: 0x0600EFAA RID: 61354 RVA: 0x0016366F File Offset: 0x0016186F
		// (set) Token: 0x0600EFAB RID: 61355 RVA: 0x00163683 File Offset: 0x00161883
		[Nullable(2)]
		public unsafe URectLightComponent RectLightComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URectLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ARectLight.__PropertyOffset_RectLightComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ARectLight.__PropertyOffset_RectLightComponent, value);
			}
		}

		// Token: 0x0600EFAC RID: 61356 RVA: 0x00163698 File Offset: 0x00161898
		static ARectLight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RectLight");
		}

		// Token: 0x0600EFAD RID: 61357 RVA: 0x001636A6 File Offset: 0x001618A6
		protected ARectLight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040081A8 RID: 33192
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RectLight";

		// Token: 0x040081A9 RID: 33193
		private static IntPtr _ClassPtr;

		// Token: 0x040081AA RID: 33194
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040081AB RID: 33195
		internal static int __PropertyOffset_RectLightComponent;
	}
}
