using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CA3 RID: 3235
	[UnrealObjectPath("/Script/Engine.InterpTrackInstFloatProp")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UInterpTrackInstFloatProp : UInterpTrackInstProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A3CB RID: 41931 RVA: 0x000E8D63 File Offset: 0x000E6F63
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackInstFloatProp._ClassPtr;
		}

		// Token: 0x0600A3CC RID: 41932 RVA: 0x000E8D70 File Offset: 0x000E6F70
		public UInterpTrackInstFloatProp() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstFloatProp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A3CD RID: 41933 RVA: 0x000E8D98 File Offset: 0x000E6F98
		[NullableContext(1)]
		public UInterpTrackInstFloatProp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstFloatProp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026F6 RID: 9974
		// (get) Token: 0x0600A3CE RID: 41934 RVA: 0x000E8DCB File Offset: 0x000E6FCB
		// (set) Token: 0x0600A3CF RID: 41935 RVA: 0x000E8DDB File Offset: 0x000E6FDB
		public unsafe float ResetFloat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackInstFloatProp.__PropertyOffset_ResetFloat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackInstFloatProp.__PropertyOffset_ResetFloat) = value;
			}
		}

		// Token: 0x0600A3D0 RID: 41936 RVA: 0x000E8DEC File Offset: 0x000E6FEC
		static UInterpTrackInstFloatProp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackInstFloatProp");
		}

		// Token: 0x0600A3D1 RID: 41937 RVA: 0x000E8DFA File Offset: 0x000E6FFA
		protected UInterpTrackInstFloatProp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A07 RID: 23047
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackInstFloatProp";

		// Token: 0x04005A08 RID: 23048
		private static IntPtr _ClassPtr;

		// Token: 0x04005A09 RID: 23049
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005A0A RID: 23050
		internal static int __PropertyOffset_ResetFloat;
	}
}
