using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C8E RID: 7310
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSDK.BasicInfo")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FBasicInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C5DC RID: 116188 RVA: 0x0029D02A File Offset: 0x0029B22A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBasicInfo._ScriptStructPtr != 0) ? FBasicInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSDK.BasicInfo", ref FBasicInfo._ScriptStructPtr);
		}

		// Token: 0x1700729D RID: 29341
		// (get) Token: 0x0601C5DD RID: 116189 RVA: 0x0029D04E File Offset: 0x0029B24E
		// (set) Token: 0x0601C5DE RID: 116190 RVA: 0x0029D062 File Offset: 0x0029B262
		public unsafe string DeviceId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FBasicInfo.__PropertyOffset_DeviceId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FBasicInfo.__PropertyOffset_DeviceId)), value);
			}
		}

		// Token: 0x1700729E RID: 29342
		// (get) Token: 0x0601C5DF RID: 116191 RVA: 0x0029D077 File Offset: 0x0029B277
		// (set) Token: 0x0601C5E0 RID: 116192 RVA: 0x0029D08B File Offset: 0x0029B28B
		public unsafe string Platform
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FBasicInfo.__PropertyOffset_Platform)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FBasicInfo.__PropertyOffset_Platform)), value);
			}
		}

		// Token: 0x1700729F RID: 29343
		// (get) Token: 0x0601C5E1 RID: 116193 RVA: 0x0029D0A0 File Offset: 0x0029B2A0
		// (set) Token: 0x0601C5E2 RID: 116194 RVA: 0x0029D0B4 File Offset: 0x0029B2B4
		public unsafe string ModelName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FBasicInfo.__PropertyOffset_ModelName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FBasicInfo.__PropertyOffset_ModelName)), value);
			}
		}

		// Token: 0x170072A0 RID: 29344
		// (get) Token: 0x0601C5E3 RID: 116195 RVA: 0x0029D0C9 File Offset: 0x0029B2C9
		// (set) Token: 0x0601C5E4 RID: 116196 RVA: 0x0029D0DD File Offset: 0x0029B2DD
		public unsafe string CPUModelName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FBasicInfo.__PropertyOffset_CPUModelName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FBasicInfo.__PropertyOffset_CPUModelName)), value);
			}
		}

		// Token: 0x170072A1 RID: 29345
		// (get) Token: 0x0601C5E5 RID: 116197 RVA: 0x0029D0F2 File Offset: 0x0029B2F2
		// (set) Token: 0x0601C5E6 RID: 116198 RVA: 0x0029D102 File Offset: 0x0029B302
		public unsafe bool bIsValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBasicInfo.__PropertyOffset_bIsValid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBasicInfo.__PropertyOffset_bIsValid) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601C5E7 RID: 116199 RVA: 0x0029D113 File Offset: 0x0029B313
		public FBasicInfo()
		{
		}

		// Token: 0x0601C5E8 RID: 116200 RVA: 0x0029D11B File Offset: 0x0029B31B
		public FBasicInfo(string DeviceId, string Platform, string ModelName, string CPUModelName, bool bIsValid)
		{
			this.DeviceId = DeviceId;
			this.Platform = Platform;
			this.ModelName = ModelName;
			this.CPUModelName = CPUModelName;
			this.bIsValid = bIsValid;
		}

		// Token: 0x0601C5E9 RID: 116201 RVA: 0x0029D148 File Offset: 0x0029B348
		protected override IntPtr GetUStructPtr()
		{
			return FBasicInfo.StaticStruct();
		}

		// Token: 0x0601C5EA RID: 116202 RVA: 0x0029D154 File Offset: 0x0029B354
		[NullableContext(2)]
		public FBasicInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C5EB RID: 116203 RVA: 0x0029D15E File Offset: 0x0029B35E
		public FBasicInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C5EC RID: 116204 RVA: 0x0029D169 File Offset: 0x0029B369
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBasicInfo(Pointer, false, true);
		}

		// Token: 0x0601C5ED RID: 116205 RVA: 0x0029D173 File Offset: 0x0029B373
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBasicInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400F3EC RID: 62444
		public const string __ObjectPath = "/Script/KuroSDK.BasicInfo";

		// Token: 0x0400F3ED RID: 62445
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F3EE RID: 62446
		internal static int __PropertyOffset_DeviceId;

		// Token: 0x0400F3EF RID: 62447
		internal static int __PropertyOffset_Platform;

		// Token: 0x0400F3F0 RID: 62448
		internal static int __PropertyOffset_ModelName;

		// Token: 0x0400F3F1 RID: 62449
		internal static int __PropertyOffset_CPUModelName;

		// Token: 0x0400F3F2 RID: 62450
		internal static int __PropertyOffset_bIsValid;
	}
}
