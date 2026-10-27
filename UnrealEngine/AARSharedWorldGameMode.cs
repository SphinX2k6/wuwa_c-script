using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003C5 RID: 965
	[UnrealObjectPath("/Script/AugmentedReality.ARSharedWorldGameMode")]
	[UnrealStructLayout(1392, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1392)]
	public class AARSharedWorldGameMode : AGameMode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600360E RID: 13838 RVA: 0x00052239 File Offset: 0x00050439
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AARSharedWorldGameMode._ClassPtr;
		}

		// Token: 0x0600360F RID: 13839 RVA: 0x00052248 File Offset: 0x00050448
		public AARSharedWorldGameMode() : this(BuiltinUtils.AllocNativeUObject(AARSharedWorldGameMode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003610 RID: 13840 RVA: 0x00052270 File Offset: 0x00050470
		[NullableContext(1)]
		public AARSharedWorldGameMode(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AARSharedWorldGameMode.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06003611 RID: 13841 RVA: 0x000522A3 File Offset: 0x000504A3
		// (set) Token: 0x06003612 RID: 13842 RVA: 0x000522B3 File Offset: 0x000504B3
		public unsafe int BufferSizePerChunk
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AARSharedWorldGameMode.__PropertyOffset_BufferSizePerChunk);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AARSharedWorldGameMode.__PropertyOffset_BufferSizePerChunk) = value;
			}
		}

		// Token: 0x06003613 RID: 13843 RVA: 0x000522C4 File Offset: 0x000504C4
		[NullableContext(2)]
		public void SetPreviewImageData(TArray<byte> ImageData)
		{
			AARSharedWorldGameMode.__SetPreviewImageData_Internal(base.NativePtr, (ImageData ?? new TArray<byte>()).NativePtr);
		}

		// Token: 0x06003614 RID: 13844 RVA: 0x000522E0 File Offset: 0x000504E0
		public void SetARWorldSharingIsReady()
		{
			AARSharedWorldGameMode.__SetARWorldSharingIsReady_Internal(base.NativePtr);
		}

		// Token: 0x06003615 RID: 13845 RVA: 0x000522ED File Offset: 0x000504ED
		[NullableContext(2)]
		public void SetARSharedWorldData(TArray<byte> ARWorldData)
		{
			AARSharedWorldGameMode.__SetARSharedWorldData_Internal(base.NativePtr, (ARWorldData ?? new TArray<byte>()).NativePtr);
		}

		// Token: 0x06003616 RID: 13846 RVA: 0x00052309 File Offset: 0x00050509
		[NullableContext(2)]
		public AARSharedWorldGameState GetARSharedWorldGameState()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AARSharedWorldGameState>(AARSharedWorldGameMode.__GetARSharedWorldGameState_Internal(base.NativePtr));
		}

		// Token: 0x06003617 RID: 13847
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPreviewImageData_Internal(IntPtr @this, IntPtr ImageData);

		// Token: 0x06003618 RID: 13848
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetARWorldSharingIsReady_Internal(IntPtr @this);

		// Token: 0x06003619 RID: 13849
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetARSharedWorldData_Internal(IntPtr @this, IntPtr ARWorldData);

		// Token: 0x0600361A RID: 13850
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetARSharedWorldGameState_Internal(IntPtr @this);

		// Token: 0x0600361B RID: 13851 RVA: 0x0005231B File Offset: 0x0005051B
		static AARSharedWorldGameMode()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARSharedWorldGameMode");
		}

		// Token: 0x0600361C RID: 13852 RVA: 0x00052329 File Offset: 0x00050529
		protected AARSharedWorldGameMode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001760 RID: 5984
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARSharedWorldGameMode";

		// Token: 0x04001761 RID: 5985
		private static IntPtr _ClassPtr;

		// Token: 0x04001762 RID: 5986
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001763 RID: 5987
		internal static int __PropertyOffset_BufferSizePerChunk;
	}
}
