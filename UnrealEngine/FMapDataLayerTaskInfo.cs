using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D6E RID: 3438
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MapDataLayerTaskInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMapDataLayerTaskInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B9A9 RID: 47529 RVA: 0x00108287 File Offset: 0x00106487
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMapDataLayerTaskInfo._ScriptStructPtr != 0) ? FMapDataLayerTaskInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MapDataLayerTaskInfo", ref FMapDataLayerTaskInfo._ScriptStructPtr);
		}

		// Token: 0x17002A89 RID: 10889
		// (get) Token: 0x0600B9AA RID: 47530 RVA: 0x001082AB File Offset: 0x001064AB
		// (set) Token: 0x0600B9AB RID: 47531 RVA: 0x001082BF File Offset: 0x001064BF
		public unsafe string TaskName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMapDataLayerTaskInfo.__PropertyOffset_TaskName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMapDataLayerTaskInfo.__PropertyOffset_TaskName)), value);
			}
		}

		// Token: 0x17002A8A RID: 10890
		// (get) Token: 0x0600B9AC RID: 47532 RVA: 0x001082D4 File Offset: 0x001064D4
		// (set) Token: 0x0600B9AD RID: 47533 RVA: 0x001082E8 File Offset: 0x001064E8
		public unsafe string DataLayerName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMapDataLayerTaskInfo.__PropertyOffset_DataLayerName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMapDataLayerTaskInfo.__PropertyOffset_DataLayerName)), value);
			}
		}

		// Token: 0x0600B9AE RID: 47534 RVA: 0x001082FD File Offset: 0x001064FD
		public FMapDataLayerTaskInfo()
		{
		}

		// Token: 0x0600B9AF RID: 47535 RVA: 0x00108305 File Offset: 0x00106505
		public FMapDataLayerTaskInfo(string TaskName, string DataLayerName)
		{
			this.TaskName = TaskName;
			this.DataLayerName = DataLayerName;
		}

		// Token: 0x0600B9B0 RID: 47536 RVA: 0x0010831B File Offset: 0x0010651B
		protected override IntPtr GetUStructPtr()
		{
			return FMapDataLayerTaskInfo.StaticStruct();
		}

		// Token: 0x0600B9B1 RID: 47537 RVA: 0x00108327 File Offset: 0x00106527
		[NullableContext(2)]
		public FMapDataLayerTaskInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B9B2 RID: 47538 RVA: 0x00108331 File Offset: 0x00106531
		public FMapDataLayerTaskInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B9B3 RID: 47539 RVA: 0x0010833C File Offset: 0x0010653C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMapDataLayerTaskInfo(Pointer, false, true);
		}

		// Token: 0x0600B9B4 RID: 47540 RVA: 0x00108346 File Offset: 0x00106546
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMapDataLayerTaskInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04006147 RID: 24903
		public const string __ObjectPath = "/Script/Engine.MapDataLayerTaskInfo";

		// Token: 0x04006148 RID: 24904
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006149 RID: 24905
		internal static int __PropertyOffset_TaskName;

		// Token: 0x0400614A RID: 24906
		internal static int __PropertyOffset_DataLayerName;
	}
}
