using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A25 RID: 6693
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPointCloud.KPCWRingBufferData")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKPCWRingBufferData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018C1A RID: 101402 RVA: 0x00249522 File Offset: 0x00247722
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKPCWRingBufferData._ScriptStructPtr != 0) ? FKPCWRingBufferData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroPointCloud.KPCWRingBufferData", ref FKPCWRingBufferData._ScriptStructPtr);
		}

		// Token: 0x17006221 RID: 25121
		// (get) Token: 0x06018C1B RID: 101403 RVA: 0x00249548 File Offset: 0x00247748
		// (set) Token: 0x06018C1C RID: 101404 RVA: 0x0024958B File Offset: 0x0024778B
		public TArray<FTransform> Transforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._Transforms) == null)
				{
					result = (this._Transforms = new TArray<FTransform>(base.NativePtr + (IntPtr)FKPCWRingBufferData.__PropertyOffset_Transforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Transforms.CopyAssign(value);
			}
		}

		// Token: 0x17006222 RID: 25122
		// (get) Token: 0x06018C1D RID: 101405 RVA: 0x00249599 File Offset: 0x00247799
		// (set) Token: 0x06018C1E RID: 101406 RVA: 0x002495A9 File Offset: 0x002477A9
		public unsafe int WriteIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKPCWRingBufferData.__PropertyOffset_WriteIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKPCWRingBufferData.__PropertyOffset_WriteIndex) = value;
			}
		}

		// Token: 0x17006223 RID: 25123
		// (get) Token: 0x06018C1F RID: 101407 RVA: 0x002495BA File Offset: 0x002477BA
		// (set) Token: 0x06018C20 RID: 101408 RVA: 0x002495CA File Offset: 0x002477CA
		public unsafe int ReadIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKPCWRingBufferData.__PropertyOffset_ReadIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKPCWRingBufferData.__PropertyOffset_ReadIndex) = value;
			}
		}

		// Token: 0x17006224 RID: 25124
		// (get) Token: 0x06018C21 RID: 101409 RVA: 0x002495DB File Offset: 0x002477DB
		// (set) Token: 0x06018C22 RID: 101410 RVA: 0x002495EB File Offset: 0x002477EB
		public unsafe int NextReadIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKPCWRingBufferData.__PropertyOffset_NextReadIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKPCWRingBufferData.__PropertyOffset_NextReadIndex) = value;
			}
		}

		// Token: 0x06018C23 RID: 101411 RVA: 0x002495FC File Offset: 0x002477FC
		public FKPCWRingBufferData()
		{
		}

		// Token: 0x06018C24 RID: 101412 RVA: 0x00249604 File Offset: 0x00247804
		public FKPCWRingBufferData(TArray<FTransform> Transforms, int WriteIndex, int ReadIndex, int NextReadIndex)
		{
			this.Transforms = Transforms;
			this.WriteIndex = WriteIndex;
			this.ReadIndex = ReadIndex;
			this.NextReadIndex = NextReadIndex;
		}

		// Token: 0x06018C25 RID: 101413 RVA: 0x00249629 File Offset: 0x00247829
		protected override IntPtr GetUStructPtr()
		{
			return FKPCWRingBufferData.StaticStruct();
		}

		// Token: 0x06018C26 RID: 101414 RVA: 0x00249635 File Offset: 0x00247835
		[NullableContext(2)]
		public FKPCWRingBufferData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018C27 RID: 101415 RVA: 0x0024963F File Offset: 0x0024783F
		public FKPCWRingBufferData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018C28 RID: 101416 RVA: 0x0024964A File Offset: 0x0024784A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKPCWRingBufferData(Pointer, false, true);
		}

		// Token: 0x06018C29 RID: 101417 RVA: 0x00249654 File Offset: 0x00247854
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKPCWRingBufferData(Pointer, MemoryOwner);
		}

		// Token: 0x0400D62C RID: 54828
		public const string __ObjectPath = "/Script/KuroPointCloud.KPCWRingBufferData";

		// Token: 0x0400D62D RID: 54829
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D62E RID: 54830
		internal static int __PropertyOffset_Transforms;

		// Token: 0x0400D62F RID: 54831
		[Nullable(2)]
		private TArray<FTransform> _Transforms;

		// Token: 0x0400D630 RID: 54832
		internal static int __PropertyOffset_WriteIndex;

		// Token: 0x0400D631 RID: 54833
		internal static int __PropertyOffset_ReadIndex;

		// Token: 0x0400D632 RID: 54834
		internal static int __PropertyOffset_NextReadIndex;
	}
}
