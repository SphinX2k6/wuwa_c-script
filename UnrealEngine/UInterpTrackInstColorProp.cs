using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C9B RID: 3227
	[UnrealObjectPath("/Script/Engine.InterpTrackInstColorProp")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UInterpTrackInstColorProp : UInterpTrackInstProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A38F RID: 41871 RVA: 0x000E878B File Offset: 0x000E698B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackInstColorProp._ClassPtr;
		}

		// Token: 0x0600A390 RID: 41872 RVA: 0x000E8798 File Offset: 0x000E6998
		public UInterpTrackInstColorProp() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstColorProp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A391 RID: 41873 RVA: 0x000E87C0 File Offset: 0x000E69C0
		[NullableContext(1)]
		public UInterpTrackInstColorProp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstColorProp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026EC RID: 9964
		// (get) Token: 0x0600A392 RID: 41874 RVA: 0x000E87F3 File Offset: 0x000E69F3
		// (set) Token: 0x0600A393 RID: 41875 RVA: 0x000E8807 File Offset: 0x000E6A07
		public unsafe FColor ResetColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackInstColorProp.__PropertyOffset_ResetColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackInstColorProp.__PropertyOffset_ResetColor) = value;
			}
		}

		// Token: 0x0600A394 RID: 41876 RVA: 0x000E881C File Offset: 0x000E6A1C
		static UInterpTrackInstColorProp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackInstColorProp");
		}

		// Token: 0x0600A395 RID: 41877 RVA: 0x000E882A File Offset: 0x000E6A2A
		protected UInterpTrackInstColorProp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040059E2 RID: 23010
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackInstColorProp";

		// Token: 0x040059E3 RID: 23011
		private static IntPtr _ClassPtr;

		// Token: 0x040059E4 RID: 23012
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040059E5 RID: 23013
		internal static int __PropertyOffset_ResetColor;
	}
}
