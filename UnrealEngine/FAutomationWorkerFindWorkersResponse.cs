using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000416 RID: 1046
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AutomationMessages.AutomationWorkerFindWorkersResponse")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FAutomationWorkerFindWorkersResponse : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003842 RID: 14402 RVA: 0x00055A41 File Offset: 0x00053C41
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationWorkerFindWorkersResponse._ScriptStructPtr != 0) ? FAutomationWorkerFindWorkersResponse._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AutomationMessages.AutomationWorkerFindWorkersResponse", ref FAutomationWorkerFindWorkersResponse._ScriptStructPtr);
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06003843 RID: 14403 RVA: 0x00055A65 File Offset: 0x00053C65
		// (set) Token: 0x06003844 RID: 14404 RVA: 0x00055A79 File Offset: 0x00053C79
		public unsafe string DeviceName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerFindWorkersResponse.__PropertyOffset_DeviceName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerFindWorkersResponse.__PropertyOffset_DeviceName)), value);
			}
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06003845 RID: 14405 RVA: 0x00055A8E File Offset: 0x00053C8E
		// (set) Token: 0x06003846 RID: 14406 RVA: 0x00055AA2 File Offset: 0x00053CA2
		public unsafe string InstanceName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerFindWorkersResponse.__PropertyOffset_InstanceName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerFindWorkersResponse.__PropertyOffset_InstanceName)), value);
			}
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x06003847 RID: 14407 RVA: 0x00055AB7 File Offset: 0x00053CB7
		// (set) Token: 0x06003848 RID: 14408 RVA: 0x00055ACB File Offset: 0x00053CCB
		public unsafe string Platform
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerFindWorkersResponse.__PropertyOffset_Platform)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerFindWorkersResponse.__PropertyOffset_Platform)), value);
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06003849 RID: 14409 RVA: 0x00055AE0 File Offset: 0x00053CE0
		// (set) Token: 0x0600384A RID: 14410 RVA: 0x00055AF4 File Offset: 0x00053CF4
		public unsafe string OSVersionName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerFindWorkersResponse.__PropertyOffset_OSVersionName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerFindWorkersResponse.__PropertyOffset_OSVersionName)), value);
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x0600384B RID: 14411 RVA: 0x00055B09 File Offset: 0x00053D09
		// (set) Token: 0x0600384C RID: 14412 RVA: 0x00055B1D File Offset: 0x00053D1D
		public unsafe string ModelName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerFindWorkersResponse.__PropertyOffset_ModelName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerFindWorkersResponse.__PropertyOffset_ModelName)), value);
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x0600384D RID: 14413 RVA: 0x00055B32 File Offset: 0x00053D32
		// (set) Token: 0x0600384E RID: 14414 RVA: 0x00055B46 File Offset: 0x00053D46
		public unsafe string GPUName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerFindWorkersResponse.__PropertyOffset_GPUName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerFindWorkersResponse.__PropertyOffset_GPUName)), value);
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x0600384F RID: 14415 RVA: 0x00055B5B File Offset: 0x00053D5B
		// (set) Token: 0x06003850 RID: 14416 RVA: 0x00055B6F File Offset: 0x00053D6F
		public unsafe string CPUModelName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerFindWorkersResponse.__PropertyOffset_CPUModelName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerFindWorkersResponse.__PropertyOffset_CPUModelName)), value);
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06003851 RID: 14417 RVA: 0x00055B84 File Offset: 0x00053D84
		// (set) Token: 0x06003852 RID: 14418 RVA: 0x00055B94 File Offset: 0x00053D94
		public unsafe uint RAMInGB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerFindWorkersResponse.__PropertyOffset_RAMInGB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerFindWorkersResponse.__PropertyOffset_RAMInGB) = (int)value;
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06003853 RID: 14419 RVA: 0x00055BA5 File Offset: 0x00053DA5
		// (set) Token: 0x06003854 RID: 14420 RVA: 0x00055BB9 File Offset: 0x00053DB9
		public unsafe string RenderModeName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerFindWorkersResponse.__PropertyOffset_RenderModeName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerFindWorkersResponse.__PropertyOffset_RenderModeName)), value);
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06003855 RID: 14421 RVA: 0x00055BCE File Offset: 0x00053DCE
		// (set) Token: 0x06003856 RID: 14422 RVA: 0x00055BE2 File Offset: 0x00053DE2
		public unsafe FGuid SessionId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerFindWorkersResponse.__PropertyOffset_SessionId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerFindWorkersResponse.__PropertyOffset_SessionId) = value;
			}
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x00055BF7 File Offset: 0x00053DF7
		public FAutomationWorkerFindWorkersResponse()
		{
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x00055C00 File Offset: 0x00053E00
		public FAutomationWorkerFindWorkersResponse(string DeviceName, string InstanceName, string Platform, string OSVersionName, string ModelName, string GPUName, string CPUModelName, uint RAMInGB, string RenderModeName, FGuid SessionId)
		{
			this.DeviceName = DeviceName;
			this.InstanceName = InstanceName;
			this.Platform = Platform;
			this.OSVersionName = OSVersionName;
			this.ModelName = ModelName;
			this.GPUName = GPUName;
			this.CPUModelName = CPUModelName;
			this.RAMInGB = RAMInGB;
			this.RenderModeName = RenderModeName;
			this.SessionId = SessionId;
		}

		// Token: 0x06003859 RID: 14425 RVA: 0x00055C60 File Offset: 0x00053E60
		protected override IntPtr GetUStructPtr()
		{
			return FAutomationWorkerFindWorkersResponse.StaticStruct();
		}

		// Token: 0x0600385A RID: 14426 RVA: 0x00055C6C File Offset: 0x00053E6C
		[NullableContext(2)]
		public FAutomationWorkerFindWorkersResponse(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600385B RID: 14427 RVA: 0x00055C76 File Offset: 0x00053E76
		public FAutomationWorkerFindWorkersResponse(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600385C RID: 14428 RVA: 0x00055C81 File Offset: 0x00053E81
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAutomationWorkerFindWorkersResponse(Pointer, false, true);
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x00055C8B File Offset: 0x00053E8B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAutomationWorkerFindWorkersResponse(Pointer, MemoryOwner);
		}

		// Token: 0x0400198F RID: 6543
		public const string __ObjectPath = "/Script/AutomationMessages.AutomationWorkerFindWorkersResponse";

		// Token: 0x04001990 RID: 6544
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001991 RID: 6545
		internal static int __PropertyOffset_DeviceName;

		// Token: 0x04001992 RID: 6546
		internal static int __PropertyOffset_InstanceName;

		// Token: 0x04001993 RID: 6547
		internal static int __PropertyOffset_Platform;

		// Token: 0x04001994 RID: 6548
		internal static int __PropertyOffset_OSVersionName;

		// Token: 0x04001995 RID: 6549
		internal static int __PropertyOffset_ModelName;

		// Token: 0x04001996 RID: 6550
		internal static int __PropertyOffset_GPUName;

		// Token: 0x04001997 RID: 6551
		internal static int __PropertyOffset_CPUModelName;

		// Token: 0x04001998 RID: 6552
		internal static int __PropertyOffset_RAMInGB;

		// Token: 0x04001999 RID: 6553
		internal static int __PropertyOffset_RenderModeName;

		// Token: 0x0400199A RID: 6554
		internal static int __PropertyOffset_SessionId;
	}
}
