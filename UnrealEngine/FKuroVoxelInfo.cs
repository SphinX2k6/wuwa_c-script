using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F42 RID: 8002
	[UnrealObjectPath("/Script/KuroVoxelRuntime.KuroVoxelInfo")]
	[UnrealStructLayout(2, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2)]
	public class FKuroVoxelInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E713 RID: 124691 RVA: 0x002D4253 File Offset: 0x002D2453
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroVoxelInfo._ScriptStructPtr != 0) ? FKuroVoxelInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVoxelRuntime.KuroVoxelInfo", ref FKuroVoxelInfo._ScriptStructPtr);
		}

		// Token: 0x1700791A RID: 31002
		// (get) Token: 0x0601E714 RID: 124692 RVA: 0x002D4277 File Offset: 0x002D2477
		// (set) Token: 0x0601E715 RID: 124693 RVA: 0x002D4287 File Offset: 0x002D2487
		public unsafe byte MtlID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroVoxelInfo.__PropertyOffset_MtlID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroVoxelInfo.__PropertyOffset_MtlID) = value;
			}
		}

		// Token: 0x1700791B RID: 31003
		// (get) Token: 0x0601E716 RID: 124694 RVA: 0x002D4298 File Offset: 0x002D2498
		// (set) Token: 0x0601E717 RID: 124695 RVA: 0x002D42A8 File Offset: 0x002D24A8
		public unsafe byte EnvType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroVoxelInfo.__PropertyOffset_EnvType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroVoxelInfo.__PropertyOffset_EnvType) = value;
			}
		}

		// Token: 0x0601E718 RID: 124696 RVA: 0x002D42B9 File Offset: 0x002D24B9
		public FKuroVoxelInfo()
		{
		}

		// Token: 0x0601E719 RID: 124697 RVA: 0x002D42C1 File Offset: 0x002D24C1
		public FKuroVoxelInfo(byte MtlID, byte EnvType)
		{
			this.MtlID = MtlID;
			this.EnvType = EnvType;
		}

		// Token: 0x0601E71A RID: 124698 RVA: 0x002D42D7 File Offset: 0x002D24D7
		protected override IntPtr GetUStructPtr()
		{
			return FKuroVoxelInfo.StaticStruct();
		}

		// Token: 0x0601E71B RID: 124699 RVA: 0x002D42E3 File Offset: 0x002D24E3
		[NullableContext(2)]
		public FKuroVoxelInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E71C RID: 124700 RVA: 0x002D42ED File Offset: 0x002D24ED
		public FKuroVoxelInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E71D RID: 124701 RVA: 0x002D42F8 File Offset: 0x002D24F8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroVoxelInfo(Pointer, false, true);
		}

		// Token: 0x0601E71E RID: 124702 RVA: 0x002D4302 File Offset: 0x002D2502
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroVoxelInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040106CE RID: 67278
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroVoxelRuntime.KuroVoxelInfo";

		// Token: 0x040106CF RID: 67279
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040106D0 RID: 67280
		internal static int __PropertyOffset_MtlID;

		// Token: 0x040106D1 RID: 67281
		internal static int __PropertyOffset_EnvType;
	}
}
