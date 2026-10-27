using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C96 RID: 3222
	[UnrealObjectPath("/Script/Engine.InterpTrackFloatProp")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UInterpTrackFloatProp : UInterpTrackFloatBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A370 RID: 41840 RVA: 0x000E84A3 File Offset: 0x000E66A3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackFloatProp._ClassPtr;
		}

		// Token: 0x0600A371 RID: 41841 RVA: 0x000E84B0 File Offset: 0x000E66B0
		public UInterpTrackFloatProp() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackFloatProp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A372 RID: 41842 RVA: 0x000E84D8 File Offset: 0x000E66D8
		[NullableContext(1)]
		public UInterpTrackFloatProp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackFloatProp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026E9 RID: 9961
		// (get) Token: 0x0600A373 RID: 41843 RVA: 0x000E850B File Offset: 0x000E670B
		// (set) Token: 0x0600A374 RID: 41844 RVA: 0x000E851F File Offset: 0x000E671F
		public unsafe FName PropertyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackFloatProp.__PropertyOffset_PropertyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackFloatProp.__PropertyOffset_PropertyName) = value;
			}
		}

		// Token: 0x0600A375 RID: 41845 RVA: 0x000E8534 File Offset: 0x000E6734
		static UInterpTrackFloatProp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackFloatProp");
		}

		// Token: 0x0600A376 RID: 41846 RVA: 0x000E8542 File Offset: 0x000E6742
		protected UInterpTrackFloatProp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040059D0 RID: 22992
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackFloatProp";

		// Token: 0x040059D1 RID: 22993
		private static IntPtr _ClassPtr;

		// Token: 0x040059D2 RID: 22994
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040059D3 RID: 22995
		internal static int __PropertyOffset_PropertyName;
	}
}
