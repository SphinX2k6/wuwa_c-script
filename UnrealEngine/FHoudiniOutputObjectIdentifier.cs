using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020014E7 RID: 5351
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniOutputObjectIdentifier")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FHoudiniOutputObjectIdentifier : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013607 RID: 79367 RVA: 0x001C7E9C File Offset: 0x001C609C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHoudiniOutputObjectIdentifier._ScriptStructPtr != 0) ? FHoudiniOutputObjectIdentifier._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.HoudiniOutputObjectIdentifier", ref FHoudiniOutputObjectIdentifier._ScriptStructPtr);
		}

		// Token: 0x17004B8F RID: 19343
		// (get) Token: 0x06013608 RID: 79368 RVA: 0x001C7EC0 File Offset: 0x001C60C0
		// (set) Token: 0x06013609 RID: 79369 RVA: 0x001C7ED0 File Offset: 0x001C60D0
		public unsafe int ObjectId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniOutputObjectIdentifier.__PropertyOffset_ObjectId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniOutputObjectIdentifier.__PropertyOffset_ObjectId) = value;
			}
		}

		// Token: 0x17004B90 RID: 19344
		// (get) Token: 0x0601360A RID: 79370 RVA: 0x001C7EE1 File Offset: 0x001C60E1
		// (set) Token: 0x0601360B RID: 79371 RVA: 0x001C7EF1 File Offset: 0x001C60F1
		public unsafe int GeoId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniOutputObjectIdentifier.__PropertyOffset_GeoId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniOutputObjectIdentifier.__PropertyOffset_GeoId) = value;
			}
		}

		// Token: 0x17004B91 RID: 19345
		// (get) Token: 0x0601360C RID: 79372 RVA: 0x001C7F02 File Offset: 0x001C6102
		// (set) Token: 0x0601360D RID: 79373 RVA: 0x001C7F12 File Offset: 0x001C6112
		public unsafe int PartId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniOutputObjectIdentifier.__PropertyOffset_PartId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniOutputObjectIdentifier.__PropertyOffset_PartId) = value;
			}
		}

		// Token: 0x17004B92 RID: 19346
		// (get) Token: 0x0601360E RID: 79374 RVA: 0x001C7F23 File Offset: 0x001C6123
		// (set) Token: 0x0601360F RID: 79375 RVA: 0x001C7F37 File Offset: 0x001C6137
		public unsafe string SplitIdentifier
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniOutputObjectIdentifier.__PropertyOffset_SplitIdentifier)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniOutputObjectIdentifier.__PropertyOffset_SplitIdentifier)), value);
			}
		}

		// Token: 0x17004B93 RID: 19347
		// (get) Token: 0x06013610 RID: 79376 RVA: 0x001C7F4C File Offset: 0x001C614C
		// (set) Token: 0x06013611 RID: 79377 RVA: 0x001C7F60 File Offset: 0x001C6160
		public unsafe string PartName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniOutputObjectIdentifier.__PropertyOffset_PartName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniOutputObjectIdentifier.__PropertyOffset_PartName)), value);
			}
		}

		// Token: 0x17004B94 RID: 19348
		// (get) Token: 0x06013612 RID: 79378 RVA: 0x001C7F75 File Offset: 0x001C6175
		// (set) Token: 0x06013613 RID: 79379 RVA: 0x001C7F85 File Offset: 0x001C6185
		public unsafe int PrimitiveIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniOutputObjectIdentifier.__PropertyOffset_PrimitiveIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniOutputObjectIdentifier.__PropertyOffset_PrimitiveIndex) = value;
			}
		}

		// Token: 0x17004B95 RID: 19349
		// (get) Token: 0x06013614 RID: 79380 RVA: 0x001C7F96 File Offset: 0x001C6196
		// (set) Token: 0x06013615 RID: 79381 RVA: 0x001C7FA6 File Offset: 0x001C61A6
		public unsafe int PointIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniOutputObjectIdentifier.__PropertyOffset_PointIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniOutputObjectIdentifier.__PropertyOffset_PointIndex) = value;
			}
		}

		// Token: 0x06013616 RID: 79382 RVA: 0x001C7FB7 File Offset: 0x001C61B7
		public FHoudiniOutputObjectIdentifier()
		{
		}

		// Token: 0x06013617 RID: 79383 RVA: 0x001C7FBF File Offset: 0x001C61BF
		public FHoudiniOutputObjectIdentifier(int ObjectId, int GeoId, int PartId, string SplitIdentifier, string PartName, int PrimitiveIndex, int PointIndex)
		{
			this.ObjectId = ObjectId;
			this.GeoId = GeoId;
			this.PartId = PartId;
			this.SplitIdentifier = SplitIdentifier;
			this.PartName = PartName;
			this.PrimitiveIndex = PrimitiveIndex;
			this.PointIndex = PointIndex;
		}

		// Token: 0x06013618 RID: 79384 RVA: 0x001C7FFC File Offset: 0x001C61FC
		protected override IntPtr GetUStructPtr()
		{
			return FHoudiniOutputObjectIdentifier.StaticStruct();
		}

		// Token: 0x06013619 RID: 79385 RVA: 0x001C8008 File Offset: 0x001C6208
		[NullableContext(2)]
		public FHoudiniOutputObjectIdentifier(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601361A RID: 79386 RVA: 0x001C8012 File Offset: 0x001C6212
		public FHoudiniOutputObjectIdentifier(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601361B RID: 79387 RVA: 0x001C801D File Offset: 0x001C621D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHoudiniOutputObjectIdentifier(Pointer, false, true);
		}

		// Token: 0x0601361C RID: 79388 RVA: 0x001C8027 File Offset: 0x001C6227
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHoudiniOutputObjectIdentifier(Pointer, MemoryOwner);
		}

		// Token: 0x0400A782 RID: 42882
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniOutputObjectIdentifier";

		// Token: 0x0400A783 RID: 42883
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A784 RID: 42884
		internal static int __PropertyOffset_ObjectId;

		// Token: 0x0400A785 RID: 42885
		internal static int __PropertyOffset_GeoId;

		// Token: 0x0400A786 RID: 42886
		internal static int __PropertyOffset_PartId;

		// Token: 0x0400A787 RID: 42887
		internal static int __PropertyOffset_SplitIdentifier;

		// Token: 0x0400A788 RID: 42888
		internal static int __PropertyOffset_PartName;

		// Token: 0x0400A789 RID: 42889
		internal static int __PropertyOffset_PrimitiveIndex;

		// Token: 0x0400A78A RID: 42890
		internal static int __PropertyOffset_PointIndex;
	}
}
