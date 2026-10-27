using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EC2 RID: 3778
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MulticastRecordOptions")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FMulticastRecordOptions : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CC91 RID: 52369 RVA: 0x0012A153 File Offset: 0x00128353
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMulticastRecordOptions._ScriptStructPtr != 0) ? FMulticastRecordOptions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MulticastRecordOptions", ref FMulticastRecordOptions._ScriptStructPtr);
		}

		// Token: 0x1700301A RID: 12314
		// (get) Token: 0x0600CC92 RID: 52370 RVA: 0x0012A177 File Offset: 0x00128377
		// (set) Token: 0x0600CC93 RID: 52371 RVA: 0x0012A18B File Offset: 0x0012838B
		public unsafe string FuncPathName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMulticastRecordOptions.__PropertyOffset_FuncPathName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMulticastRecordOptions.__PropertyOffset_FuncPathName)), value);
			}
		}

		// Token: 0x1700301B RID: 12315
		// (get) Token: 0x0600CC94 RID: 52372 RVA: 0x0012A1A0 File Offset: 0x001283A0
		// (set) Token: 0x0600CC95 RID: 52373 RVA: 0x0012A1B0 File Offset: 0x001283B0
		public unsafe bool bServerSkip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMulticastRecordOptions.__PropertyOffset_bServerSkip) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMulticastRecordOptions.__PropertyOffset_bServerSkip) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700301C RID: 12316
		// (get) Token: 0x0600CC96 RID: 52374 RVA: 0x0012A1C1 File Offset: 0x001283C1
		// (set) Token: 0x0600CC97 RID: 52375 RVA: 0x0012A1D1 File Offset: 0x001283D1
		public unsafe bool bClientSkip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMulticastRecordOptions.__PropertyOffset_bClientSkip) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMulticastRecordOptions.__PropertyOffset_bClientSkip) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600CC98 RID: 52376 RVA: 0x0012A1E2 File Offset: 0x001283E2
		public FMulticastRecordOptions()
		{
		}

		// Token: 0x0600CC99 RID: 52377 RVA: 0x0012A1EA File Offset: 0x001283EA
		public FMulticastRecordOptions(string FuncPathName, bool bServerSkip, bool bClientSkip)
		{
			this.FuncPathName = FuncPathName;
			this.bServerSkip = bServerSkip;
			this.bClientSkip = bClientSkip;
		}

		// Token: 0x0600CC9A RID: 52378 RVA: 0x0012A207 File Offset: 0x00128407
		protected override IntPtr GetUStructPtr()
		{
			return FMulticastRecordOptions.StaticStruct();
		}

		// Token: 0x0600CC9B RID: 52379 RVA: 0x0012A213 File Offset: 0x00128413
		[NullableContext(2)]
		public FMulticastRecordOptions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CC9C RID: 52380 RVA: 0x0012A21D File Offset: 0x0012841D
		public FMulticastRecordOptions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CC9D RID: 52381 RVA: 0x0012A228 File Offset: 0x00128428
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMulticastRecordOptions(Pointer, false, true);
		}

		// Token: 0x0600CC9E RID: 52382 RVA: 0x0012A232 File Offset: 0x00128432
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMulticastRecordOptions(Pointer, MemoryOwner);
		}

		// Token: 0x04006E29 RID: 28201
		public const string __ObjectPath = "/Script/Engine.MulticastRecordOptions";

		// Token: 0x04006E2A RID: 28202
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006E2B RID: 28203
		internal static int __PropertyOffset_FuncPathName;

		// Token: 0x04006E2C RID: 28204
		internal static int __PropertyOffset_bServerSkip;

		// Token: 0x04006E2D RID: 28205
		internal static int __PropertyOffset_bClientSkip;
	}
}
