using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C8D RID: 3213
	[UnrealObjectPath("/Script/Engine.InterpTrackColorProp")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UInterpTrackColorProp : UInterpTrackVectorBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A31E RID: 41758 RVA: 0x000E7BE3 File Offset: 0x000E5DE3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackColorProp._ClassPtr;
		}

		// Token: 0x0600A31F RID: 41759 RVA: 0x000E7BF0 File Offset: 0x000E5DF0
		public UInterpTrackColorProp() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackColorProp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A320 RID: 41760 RVA: 0x000E7C18 File Offset: 0x000E5E18
		[NullableContext(1)]
		public UInterpTrackColorProp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackColorProp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026D6 RID: 9942
		// (get) Token: 0x0600A321 RID: 41761 RVA: 0x000E7C4B File Offset: 0x000E5E4B
		// (set) Token: 0x0600A322 RID: 41762 RVA: 0x000E7C5F File Offset: 0x000E5E5F
		public unsafe FName PropertyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackColorProp.__PropertyOffset_PropertyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackColorProp.__PropertyOffset_PropertyName) = value;
			}
		}

		// Token: 0x0600A323 RID: 41763 RVA: 0x000E7C74 File Offset: 0x000E5E74
		static UInterpTrackColorProp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackColorProp");
		}

		// Token: 0x0600A324 RID: 41764 RVA: 0x000E7C82 File Offset: 0x000E5E82
		protected UInterpTrackColorProp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005997 RID: 22935
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackColorProp";

		// Token: 0x04005998 RID: 22936
		private static IntPtr _ClassPtr;

		// Token: 0x04005999 RID: 22937
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400599A RID: 22938
		internal static int __PropertyOffset_PropertyName;
	}
}
