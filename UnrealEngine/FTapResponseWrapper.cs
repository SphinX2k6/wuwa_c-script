using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028E6 RID: 10470
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TapCommon.TapResponseWrapper")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FTapResponseWrapper : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026D59 RID: 159065 RVA: 0x003B39A5 File Offset: 0x003B1BA5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTapResponseWrapper._ScriptStructPtr != 0) ? FTapResponseWrapper._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TapCommon.TapResponseWrapper", ref FTapResponseWrapper._ScriptStructPtr);
		}

		// Token: 0x17009596 RID: 38294
		// (get) Token: 0x06026D5A RID: 159066 RVA: 0x003B39C9 File Offset: 0x003B1BC9
		// (set) Token: 0x06026D5B RID: 159067 RVA: 0x003B39D9 File Offset: 0x003B1BD9
		public unsafe bool Success
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTapResponseWrapper.__PropertyOffset_Success) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTapResponseWrapper.__PropertyOffset_Success) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009597 RID: 38295
		// (get) Token: 0x06026D5C RID: 159068 RVA: 0x003B39EC File Offset: 0x003B1BEC
		// (set) Token: 0x06026D5D RID: 159069 RVA: 0x003B3A2F File Offset: 0x003B1C2F
		public FJsonObjectWrapper Data
		{
			get
			{
				base.FastCheckIsValid();
				FJsonObjectWrapper result;
				if ((result = this._Data) == null)
				{
					result = (this._Data = new FJsonObjectWrapper(base.NativePtr + (IntPtr)FTapResponseWrapper.__PropertyOffset_Data, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FJsonObjectWrapper.StaticStruct(), base.NativePtr + (IntPtr)FTapResponseWrapper.__PropertyOffset_Data, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009598 RID: 38296
		// (get) Token: 0x06026D5E RID: 159070 RVA: 0x003B3A50 File Offset: 0x003B1C50
		// (set) Token: 0x06026D5F RID: 159071 RVA: 0x003B3A60 File Offset: 0x003B1C60
		public unsafe long Now
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTapResponseWrapper.__PropertyOffset_Now);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTapResponseWrapper.__PropertyOffset_Now) = value;
			}
		}

		// Token: 0x06026D60 RID: 159072 RVA: 0x003B3A71 File Offset: 0x003B1C71
		public FTapResponseWrapper()
		{
		}

		// Token: 0x06026D61 RID: 159073 RVA: 0x003B3A79 File Offset: 0x003B1C79
		public FTapResponseWrapper(bool Success, FJsonObjectWrapper Data, long Now)
		{
			this.Success = Success;
			this.Data = Data;
			this.Now = Now;
		}

		// Token: 0x06026D62 RID: 159074 RVA: 0x003B3A96 File Offset: 0x003B1C96
		protected override IntPtr GetUStructPtr()
		{
			return FTapResponseWrapper.StaticStruct();
		}

		// Token: 0x06026D63 RID: 159075 RVA: 0x003B3AA2 File Offset: 0x003B1CA2
		[NullableContext(2)]
		public FTapResponseWrapper(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026D64 RID: 159076 RVA: 0x003B3AAC File Offset: 0x003B1CAC
		public FTapResponseWrapper(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026D65 RID: 159077 RVA: 0x003B3AB7 File Offset: 0x003B1CB7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTapResponseWrapper(Pointer, false, true);
		}

		// Token: 0x06026D66 RID: 159078 RVA: 0x003B3AC1 File Offset: 0x003B1CC1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTapResponseWrapper(Pointer, MemoryOwner);
		}

		// Token: 0x0401551B RID: 87323
		public const string __ObjectPath = "/Script/TapCommon.TapResponseWrapper";

		// Token: 0x0401551C RID: 87324
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401551D RID: 87325
		internal static int __PropertyOffset_Success;

		// Token: 0x0401551E RID: 87326
		internal static int __PropertyOffset_Data;

		// Token: 0x0401551F RID: 87327
		[Nullable(2)]
		private FJsonObjectWrapper _Data;

		// Token: 0x04015520 RID: 87328
		internal static int __PropertyOffset_Now;
	}
}
