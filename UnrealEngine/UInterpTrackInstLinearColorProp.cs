using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CA4 RID: 3236
	[UnrealObjectPath("/Script/Engine.InterpTrackInstLinearColorProp")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UInterpTrackInstLinearColorProp : UInterpTrackInstProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A3D2 RID: 41938 RVA: 0x000E8E03 File Offset: 0x000E7003
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackInstLinearColorProp._ClassPtr;
		}

		// Token: 0x0600A3D3 RID: 41939 RVA: 0x000E8E10 File Offset: 0x000E7010
		public UInterpTrackInstLinearColorProp() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstLinearColorProp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A3D4 RID: 41940 RVA: 0x000E8E38 File Offset: 0x000E7038
		[NullableContext(1)]
		public UInterpTrackInstLinearColorProp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstLinearColorProp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026F7 RID: 9975
		// (get) Token: 0x0600A3D5 RID: 41941 RVA: 0x000E8E6B File Offset: 0x000E706B
		// (set) Token: 0x0600A3D6 RID: 41942 RVA: 0x000E8E7F File Offset: 0x000E707F
		public unsafe FLinearColor ResetColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackInstLinearColorProp.__PropertyOffset_ResetColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackInstLinearColorProp.__PropertyOffset_ResetColor) = value;
			}
		}

		// Token: 0x0600A3D7 RID: 41943 RVA: 0x000E8E94 File Offset: 0x000E7094
		static UInterpTrackInstLinearColorProp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackInstLinearColorProp");
		}

		// Token: 0x0600A3D8 RID: 41944 RVA: 0x000E8EA2 File Offset: 0x000E70A2
		protected UInterpTrackInstLinearColorProp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A0B RID: 23051
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackInstLinearColorProp";

		// Token: 0x04005A0C RID: 23052
		private static IntPtr _ClassPtr;

		// Token: 0x04005A0D RID: 23053
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005A0E RID: 23054
		internal static int __PropertyOffset_ResetColor;
	}
}
