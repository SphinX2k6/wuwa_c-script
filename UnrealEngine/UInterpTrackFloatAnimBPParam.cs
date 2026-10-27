using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C92 RID: 3218
	[UnrealObjectPath("/Script/Engine.InterpTrackFloatAnimBPParam")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UInterpTrackFloatAnimBPParam : UInterpTrackFloatBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A34D RID: 41805 RVA: 0x000E8141 File Offset: 0x000E6341
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackFloatAnimBPParam._ClassPtr;
		}

		// Token: 0x0600A34E RID: 41806 RVA: 0x000E8150 File Offset: 0x000E6350
		public UInterpTrackFloatAnimBPParam() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackFloatAnimBPParam.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A34F RID: 41807 RVA: 0x000E8178 File Offset: 0x000E6378
		[NullableContext(1)]
		public UInterpTrackFloatAnimBPParam(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackFloatAnimBPParam.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026E1 RID: 9953
		// (get) Token: 0x0600A350 RID: 41808 RVA: 0x000E81AB File Offset: 0x000E63AB
		// (set) Token: 0x0600A351 RID: 41809 RVA: 0x000E81BF File Offset: 0x000E63BF
		public unsafe UClassStackOnlyPtr AnimBlueprintClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackFloatAnimBPParam.__PropertyOffset_AnimBlueprintClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackFloatAnimBPParam.__PropertyOffset_AnimBlueprintClass) = value;
			}
		}

		// Token: 0x170026E2 RID: 9954
		// (get) Token: 0x0600A352 RID: 41810 RVA: 0x000E81D4 File Offset: 0x000E63D4
		// (set) Token: 0x0600A353 RID: 41811 RVA: 0x000E81E8 File Offset: 0x000E63E8
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UAnimInstance> AnimClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackFloatAnimBPParam.__PropertyOffset_AnimClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackFloatAnimBPParam.__PropertyOffset_AnimClass) = value;
			}
		}

		// Token: 0x170026E3 RID: 9955
		// (get) Token: 0x0600A354 RID: 41812 RVA: 0x000E81FD File Offset: 0x000E63FD
		// (set) Token: 0x0600A355 RID: 41813 RVA: 0x000E8211 File Offset: 0x000E6411
		public unsafe FName ParamName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackFloatAnimBPParam.__PropertyOffset_ParamName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackFloatAnimBPParam.__PropertyOffset_ParamName) = value;
			}
		}

		// Token: 0x0600A356 RID: 41814 RVA: 0x000E8226 File Offset: 0x000E6426
		static UInterpTrackFloatAnimBPParam()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackFloatAnimBPParam");
		}

		// Token: 0x0600A357 RID: 41815 RVA: 0x000E8234 File Offset: 0x000E6434
		protected UInterpTrackFloatAnimBPParam(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040059BA RID: 22970
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackFloatAnimBPParam";

		// Token: 0x040059BB RID: 22971
		private static IntPtr _ClassPtr;

		// Token: 0x040059BC RID: 22972
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040059BD RID: 22973
		internal static int __PropertyOffset_AnimBlueprintClass;

		// Token: 0x040059BE RID: 22974
		internal static int __PropertyOffset_AnimClass;

		// Token: 0x040059BF RID: 22975
		internal static int __PropertyOffset_ParamName;
	}
}
