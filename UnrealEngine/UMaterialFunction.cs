using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E80 RID: 3712
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialFunction")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UMaterialFunction : UMaterialFunctionInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C639 RID: 50745 RVA: 0x0011F2D7 File Offset: 0x0011D4D7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialFunction._ClassPtr;
		}

		// Token: 0x0600C63A RID: 50746 RVA: 0x0011F2E4 File Offset: 0x0011D4E4
		public UMaterialFunction() : this(BuiltinUtils.AllocNativeUObject(UMaterialFunction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C63B RID: 50747 RVA: 0x0011F30C File Offset: 0x0011D50C
		public UMaterialFunction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialFunction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002E01 RID: 11777
		// (get) Token: 0x0600C63C RID: 50748 RVA: 0x0011F33F File Offset: 0x0011D53F
		// (set) Token: 0x0600C63D RID: 50749 RVA: 0x0011F353 File Offset: 0x0011D553
		public unsafe string Description
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UMaterialFunction.__PropertyOffset_Description)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UMaterialFunction.__PropertyOffset_Description)), value);
			}
		}

		// Token: 0x17002E02 RID: 11778
		// (get) Token: 0x0600C63E RID: 50750 RVA: 0x0011F368 File Offset: 0x0011D568
		// (set) Token: 0x0600C63F RID: 50751 RVA: 0x0011F381 File Offset: 0x0011D581
		public unsafe bool bExposeToLibrary
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialFunction.__PropertyOffset_bExposeToLibrary) & UMaterialFunction.__PropertyMask_bExposeToLibrary) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialFunction.__PropertyOffset_bExposeToLibrary) = ((*(base.NativePtr + (IntPtr)UMaterialFunction.__PropertyOffset_bExposeToLibrary) & ~UMaterialFunction.__PropertyMask_bExposeToLibrary) | (value ? UMaterialFunction.__PropertyMask_bExposeToLibrary : 0));
			}
		}

		// Token: 0x17002E03 RID: 11779
		// (get) Token: 0x0600C640 RID: 50752 RVA: 0x0011F3B1 File Offset: 0x0011D5B1
		// (set) Token: 0x0600C641 RID: 50753 RVA: 0x0011F3CA File Offset: 0x0011D5CA
		public unsafe bool bPrefixParameterNames
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialFunction.__PropertyOffset_bPrefixParameterNames) & UMaterialFunction.__PropertyMask_bPrefixParameterNames) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialFunction.__PropertyOffset_bPrefixParameterNames) = ((*(base.NativePtr + (IntPtr)UMaterialFunction.__PropertyOffset_bPrefixParameterNames) & ~UMaterialFunction.__PropertyMask_bPrefixParameterNames) | (value ? UMaterialFunction.__PropertyMask_bPrefixParameterNames : 0));
			}
		}

		// Token: 0x0600C642 RID: 50754 RVA: 0x0011F3FA File Offset: 0x0011D5FA
		static UMaterialFunction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialFunction");
		}

		// Token: 0x0600C643 RID: 50755 RVA: 0x0011F408 File Offset: 0x0011D608
		protected UMaterialFunction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006A1B RID: 27163
		public new const string __ObjectPath = "/Script/Engine.MaterialFunction";

		// Token: 0x04006A1C RID: 27164
		private static IntPtr _ClassPtr;

		// Token: 0x04006A1D RID: 27165
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006A1E RID: 27166
		internal static int __PropertyOffset_Description;

		// Token: 0x04006A1F RID: 27167
		internal static int __PropertyOffset_bExposeToLibrary;

		// Token: 0x04006A20 RID: 27168
		internal static byte __PropertyMask_bExposeToLibrary;

		// Token: 0x04006A21 RID: 27169
		internal static int __PropertyOffset_bPrefixParameterNames;

		// Token: 0x04006A22 RID: 27170
		internal static byte __PropertyMask_bPrefixParameterNames;
	}
}
