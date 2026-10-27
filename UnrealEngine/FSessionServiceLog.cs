using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002725 RID: 10021
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SessionMessages.SessionServiceLog")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FSessionServiceLog : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602522E RID: 152110 RVA: 0x003700F9 File Offset: 0x0036E2F9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSessionServiceLog._ScriptStructPtr != 0) ? FSessionServiceLog._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SessionMessages.SessionServiceLog", ref FSessionServiceLog._ScriptStructPtr);
		}

		// Token: 0x17008F54 RID: 36692
		// (get) Token: 0x0602522F RID: 152111 RVA: 0x0037011D File Offset: 0x0036E31D
		// (set) Token: 0x06025230 RID: 152112 RVA: 0x00370131 File Offset: 0x0036E331
		public unsafe FName Category
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSessionServiceLog.__PropertyOffset_Category);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSessionServiceLog.__PropertyOffset_Category) = value;
			}
		}

		// Token: 0x17008F55 RID: 36693
		// (get) Token: 0x06025231 RID: 152113 RVA: 0x00370146 File Offset: 0x0036E346
		// (set) Token: 0x06025232 RID: 152114 RVA: 0x0037015A File Offset: 0x0036E35A
		public unsafe string Data
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSessionServiceLog.__PropertyOffset_Data)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSessionServiceLog.__PropertyOffset_Data)), value);
			}
		}

		// Token: 0x17008F56 RID: 36694
		// (get) Token: 0x06025233 RID: 152115 RVA: 0x0037016F File Offset: 0x0036E36F
		// (set) Token: 0x06025234 RID: 152116 RVA: 0x00370183 File Offset: 0x0036E383
		public unsafe FGuid InstanceId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSessionServiceLog.__PropertyOffset_InstanceId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSessionServiceLog.__PropertyOffset_InstanceId) = value;
			}
		}

		// Token: 0x17008F57 RID: 36695
		// (get) Token: 0x06025235 RID: 152117 RVA: 0x00370198 File Offset: 0x0036E398
		// (set) Token: 0x06025236 RID: 152118 RVA: 0x003701A8 File Offset: 0x0036E3A8
		public unsafe double TimeSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSessionServiceLog.__PropertyOffset_TimeSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSessionServiceLog.__PropertyOffset_TimeSeconds) = value;
			}
		}

		// Token: 0x17008F58 RID: 36696
		// (get) Token: 0x06025237 RID: 152119 RVA: 0x003701B9 File Offset: 0x0036E3B9
		// (set) Token: 0x06025238 RID: 152120 RVA: 0x003701C9 File Offset: 0x0036E3C9
		public unsafe byte Verbosity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSessionServiceLog.__PropertyOffset_Verbosity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSessionServiceLog.__PropertyOffset_Verbosity) = value;
			}
		}

		// Token: 0x06025239 RID: 152121 RVA: 0x003701DA File Offset: 0x0036E3DA
		public FSessionServiceLog()
		{
		}

		// Token: 0x0602523A RID: 152122 RVA: 0x003701E2 File Offset: 0x0036E3E2
		public FSessionServiceLog(FName Category, string Data, FGuid InstanceId, double TimeSeconds, byte Verbosity)
		{
			this.Category = Category;
			this.Data = Data;
			this.InstanceId = InstanceId;
			this.TimeSeconds = TimeSeconds;
			this.Verbosity = Verbosity;
		}

		// Token: 0x0602523B RID: 152123 RVA: 0x0037020F File Offset: 0x0036E40F
		protected override IntPtr GetUStructPtr()
		{
			return FSessionServiceLog.StaticStruct();
		}

		// Token: 0x0602523C RID: 152124 RVA: 0x0037021B File Offset: 0x0036E41B
		[NullableContext(2)]
		public FSessionServiceLog(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602523D RID: 152125 RVA: 0x00370225 File Offset: 0x0036E425
		public FSessionServiceLog(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602523E RID: 152126 RVA: 0x00370230 File Offset: 0x0036E430
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSessionServiceLog(Pointer, false, true);
		}

		// Token: 0x0602523F RID: 152127 RVA: 0x0037023A File Offset: 0x0036E43A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSessionServiceLog(Pointer, MemoryOwner);
		}

		// Token: 0x04014034 RID: 81972
		public const string __ObjectPath = "/Script/SessionMessages.SessionServiceLog";

		// Token: 0x04014035 RID: 81973
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014036 RID: 81974
		internal static int __PropertyOffset_Category;

		// Token: 0x04014037 RID: 81975
		internal static int __PropertyOffset_Data;

		// Token: 0x04014038 RID: 81976
		internal static int __PropertyOffset_InstanceId;

		// Token: 0x04014039 RID: 81977
		internal static int __PropertyOffset_TimeSeconds;

		// Token: 0x0401403A RID: 81978
		internal static int __PropertyOffset_Verbosity;
	}
}
