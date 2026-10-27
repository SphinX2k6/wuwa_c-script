using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000CC RID: 204
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ACLPlugin.AnimationCompressionLibraryDatabase")]
	[UnrealStructLayout(616, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 616)]
	public class UAnimationCompressionLibraryDatabase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001131 RID: 4401 RVA: 0x00019952 File Offset: 0x00017B52
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimationCompressionLibraryDatabase._ClassPtr;
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x00019960 File Offset: 0x00017B60
		public UAnimationCompressionLibraryDatabase() : this(BuiltinUtils.AllocNativeUObject(UAnimationCompressionLibraryDatabase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x00019988 File Offset: 0x00017B88
		public UAnimationCompressionLibraryDatabase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimationCompressionLibraryDatabase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x000199BC File Offset: 0x00017BBC
		// (set) Token: 0x06001135 RID: 4405 RVA: 0x000199F5 File Offset: 0x00017BF5
		public TArray<byte> CookedCompressedBytes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._CookedCompressedBytes) == null)
				{
					result = (this._CookedCompressedBytes = new TArray<byte>(base.NativePtr + (IntPtr)UAnimationCompressionLibraryDatabase.__PropertyOffset_CookedCompressedBytes, this));
				}
				return result;
			}
			set
			{
				this.CookedCompressedBytes.CopyAssign(value);
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x00019A04 File Offset: 0x00017C04
		// (set) Token: 0x06001137 RID: 4407 RVA: 0x00019A3D File Offset: 0x00017C3D
		public TArray<ulong> CookedAnimSequenceMappings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ulong> result;
				if ((result = this._CookedAnimSequenceMappings) == null)
				{
					result = (this._CookedAnimSequenceMappings = new TArray<ulong>(base.NativePtr + (IntPtr)UAnimationCompressionLibraryDatabase.__PropertyOffset_CookedAnimSequenceMappings, this));
				}
				return result;
			}
			set
			{
				this.CookedAnimSequenceMappings.CopyAssign(value);
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x00019A4B File Offset: 0x00017C4B
		// (set) Token: 0x06001139 RID: 4409 RVA: 0x00019A5B File Offset: 0x00017C5B
		public unsafe uint MaxStreamRequestSizeKB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimationCompressionLibraryDatabase.__PropertyOffset_MaxStreamRequestSizeKB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimationCompressionLibraryDatabase.__PropertyOffset_MaxStreamRequestSizeKB) = (int)value;
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x00019A6C File Offset: 0x00017C6C
		// (set) Token: 0x0600113B RID: 4411 RVA: 0x00019A7C File Offset: 0x00017C7C
		public unsafe ACLVisualFidelity DefaultVisualFidelity
		{
			get
			{
				return (ACLVisualFidelity)(*(base.NativePtr + (IntPtr)UAnimationCompressionLibraryDatabase.__PropertyOffset_DefaultVisualFidelity));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimationCompressionLibraryDatabase.__PropertyOffset_DefaultVisualFidelity) = (byte)value;
			}
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x00019A90 File Offset: 0x00017C90
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetVisualFidelity(UObject WorldContextObject, FLatentActionInfo LatentInfo, UAnimationCompressionLibraryDatabase DatabaseAsset, ref ACLVisualFidelityChangeResult Result, ACLVisualFidelity VisualFidelity = ACLVisualFidelity.Highest)
		{
			UAnimationCompressionLibraryDatabase.__SetVisualFidelity_FunctionParams* ptr = stackalloc UAnimationCompressionLibraryDatabase.__SetVisualFidelity_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UAnimationCompressionLibraryDatabase.__SetVisualFidelity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnimationCompressionLibraryDatabase.__SetVisualFidelity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			if (LatentInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FLatentActionInfo.StaticStruct(), &ptr->LatentInfo, LatentInfo.NativePtr, 1, false);
			}
			ptr->DatabaseAsset = ((DatabaseAsset != null) ? DatabaseAsset.NativePtr : IntPtr.Zero);
			ptr->Result = Result;
			ptr->VisualFidelity = VisualFidelity;
			UnrealReflectionUtils.CallUFunction(UAnimationCompressionLibraryDatabase._ClassDefaultObjectPtr, UAnimationCompressionLibraryDatabase.__SetVisualFidelity_NativeFunctionPtr, (void*)ptr, 0);
			Result = ptr->Result;
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x00019B38 File Offset: 0x00017D38
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static ACLVisualFidelity GetVisualFidelity(UAnimationCompressionLibraryDatabase DatabaseAsset)
		{
			UAnimationCompressionLibraryDatabase.__GetVisualFidelity_FunctionParams* ptr = stackalloc UAnimationCompressionLibraryDatabase.__GetVisualFidelity_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAnimationCompressionLibraryDatabase.__GetVisualFidelity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnimationCompressionLibraryDatabase.__GetVisualFidelity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DatabaseAsset = ((DatabaseAsset != null) ? DatabaseAsset.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UAnimationCompressionLibraryDatabase._ClassDefaultObjectPtr, UAnimationCompressionLibraryDatabase.__GetVisualFidelity_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x00019B93 File Offset: 0x00017D93
		static UAnimationCompressionLibraryDatabase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ACLPlugin.AnimationCompressionLibraryDatabase");
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x00019BA1 File Offset: 0x00017DA1
		protected UAnimationCompressionLibraryDatabase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400028B RID: 651
		public new const string __ObjectPath = "/Script/ACLPlugin.AnimationCompressionLibraryDatabase";

		// Token: 0x0400028C RID: 652
		private static IntPtr _ClassPtr;

		// Token: 0x0400028D RID: 653
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400028E RID: 654
		internal static int __PropertyOffset_CookedCompressedBytes;

		// Token: 0x0400028F RID: 655
		[Nullable(2)]
		private TArray<byte> _CookedCompressedBytes;

		// Token: 0x04000290 RID: 656
		internal static int __PropertyOffset_CookedAnimSequenceMappings;

		// Token: 0x04000291 RID: 657
		[Nullable(2)]
		private TArray<ulong> _CookedAnimSequenceMappings;

		// Token: 0x04000292 RID: 658
		internal static int __PropertyOffset_MaxStreamRequestSizeKB;

		// Token: 0x04000293 RID: 659
		internal static int __PropertyOffset_DefaultVisualFidelity;

		// Token: 0x04000294 RID: 660
		private static IntPtr __SetVisualFidelity_NativeFunctionPtr;

		// Token: 0x04000295 RID: 661
		private static IntPtr __GetVisualFidelity_NativeFunctionPtr;

		// Token: 0x02002B39 RID: 11065
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __SetVisualFidelity_FunctionParams
		{
			// Token: 0x04016391 RID: 91025
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x04016392 RID: 91026
			[FieldOffset(8)]
			public byte LatentInfo;

			// Token: 0x04016393 RID: 91027
			[FieldOffset(40)]
			public IntPtr DatabaseAsset;

			// Token: 0x04016394 RID: 91028
			[FieldOffset(48)]
			public ACLVisualFidelityChangeResult Result;

			// Token: 0x04016395 RID: 91029
			[FieldOffset(49)]
			public ACLVisualFidelity VisualFidelity;
		}

		// Token: 0x02002B3A RID: 11066
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetVisualFidelity_FunctionParams
		{
			// Token: 0x04016396 RID: 91030
			[FieldOffset(0)]
			public IntPtr DatabaseAsset;

			// Token: 0x04016397 RID: 91031
			[FieldOffset(8)]
			public ACLVisualFidelity __Result;
		}
	}
}
