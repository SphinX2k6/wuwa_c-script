using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C9A RID: 3226
	[UnrealObjectPath("/Script/Engine.InterpTrackInstBoolProp")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UInterpTrackInstBoolProp : UInterpTrackInstProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A388 RID: 41864 RVA: 0x000E86EA File Offset: 0x000E68EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackInstBoolProp._ClassPtr;
		}

		// Token: 0x0600A389 RID: 41865 RVA: 0x000E86F8 File Offset: 0x000E68F8
		public UInterpTrackInstBoolProp() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstBoolProp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A38A RID: 41866 RVA: 0x000E8720 File Offset: 0x000E6920
		[NullableContext(1)]
		public UInterpTrackInstBoolProp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstBoolProp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026EB RID: 9963
		// (get) Token: 0x0600A38B RID: 41867 RVA: 0x000E8753 File Offset: 0x000E6953
		// (set) Token: 0x0600A38C RID: 41868 RVA: 0x000E8763 File Offset: 0x000E6963
		public unsafe bool ResetBool
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackInstBoolProp.__PropertyOffset_ResetBool) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackInstBoolProp.__PropertyOffset_ResetBool) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600A38D RID: 41869 RVA: 0x000E8774 File Offset: 0x000E6974
		static UInterpTrackInstBoolProp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackInstBoolProp");
		}

		// Token: 0x0600A38E RID: 41870 RVA: 0x000E8782 File Offset: 0x000E6982
		protected UInterpTrackInstBoolProp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040059DE RID: 23006
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackInstBoolProp";

		// Token: 0x040059DF RID: 23007
		private static IntPtr _ClassPtr;

		// Token: 0x040059E0 RID: 23008
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040059E1 RID: 23009
		internal static int __PropertyOffset_ResetBool;
	}
}
