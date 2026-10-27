using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A5E RID: 6750
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.ConditionalCMD")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FConditionalCMD : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018FCC RID: 102348 RVA: 0x0024EF67 File Offset: 0x0024D167
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FConditionalCMD._ScriptStructPtr != 0) ? FConditionalCMD._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.ConditionalCMD", ref FConditionalCMD._ScriptStructPtr);
		}

		// Token: 0x1700630C RID: 25356
		// (get) Token: 0x06018FCD RID: 102349 RVA: 0x0024EF8B File Offset: 0x0024D18B
		// (set) Token: 0x06018FCE RID: 102350 RVA: 0x0024EF9F File Offset: 0x0024D19F
		public unsafe string Command
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FConditionalCMD.__PropertyOffset_Command)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FConditionalCMD.__PropertyOffset_Command)), value);
			}
		}

		// Token: 0x1700630D RID: 25357
		// (get) Token: 0x06018FCF RID: 102351 RVA: 0x0024EFB4 File Offset: 0x0024D1B4
		// (set) Token: 0x06018FD0 RID: 102352 RVA: 0x0024EFC4 File Offset: 0x0024D1C4
		public unsafe bool bMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConditionalCMD.__PropertyOffset_bMobile) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConditionalCMD.__PropertyOffset_bMobile) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700630E RID: 25358
		// (get) Token: 0x06018FD1 RID: 102353 RVA: 0x0024EFD5 File Offset: 0x0024D1D5
		// (set) Token: 0x06018FD2 RID: 102354 RVA: 0x0024EFE5 File Offset: 0x0024D1E5
		public unsafe bool bPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConditionalCMD.__PropertyOffset_bPC) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConditionalCMD.__PropertyOffset_bPC) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700630F RID: 25359
		// (get) Token: 0x06018FD3 RID: 102355 RVA: 0x0024EFF6 File Offset: 0x0024D1F6
		// (set) Token: 0x06018FD4 RID: 102356 RVA: 0x0024F006 File Offset: 0x0024D206
		public unsafe bool bOnlyForLowMemory
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConditionalCMD.__PropertyOffset_bOnlyForLowMemory) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConditionalCMD.__PropertyOffset_bOnlyForLowMemory) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006310 RID: 25360
		// (get) Token: 0x06018FD5 RID: 102357 RVA: 0x0024F018 File Offset: 0x0024D218
		// (set) Token: 0x06018FD6 RID: 102358 RVA: 0x0024F05B File Offset: 0x0024D25B
		public FConditionalCMDQualityLevel QualityLevelConditional
		{
			get
			{
				base.FastCheckIsValid();
				FConditionalCMDQualityLevel result;
				if ((result = this._QualityLevelConditional) == null)
				{
					result = (this._QualityLevelConditional = new FConditionalCMDQualityLevel(base.NativePtr + (IntPtr)FConditionalCMD.__PropertyOffset_QualityLevelConditional, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FConditionalCMDQualityLevel.StaticStruct(), base.NativePtr + (IntPtr)FConditionalCMD.__PropertyOffset_QualityLevelConditional, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006311 RID: 25361
		// (get) Token: 0x06018FD7 RID: 102359 RVA: 0x0024F07C File Offset: 0x0024D27C
		// (set) Token: 0x06018FD8 RID: 102360 RVA: 0x0024F08C File Offset: 0x0024D28C
		public unsafe bool bSetByConsole
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConditionalCMD.__PropertyOffset_bSetByConsole) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConditionalCMD.__PropertyOffset_bSetByConsole) = (value ? 1 : 0);
			}
		}

		// Token: 0x06018FD9 RID: 102361 RVA: 0x0024F09D File Offset: 0x0024D29D
		public FConditionalCMD()
		{
		}

		// Token: 0x06018FDA RID: 102362 RVA: 0x0024F0A5 File Offset: 0x0024D2A5
		public FConditionalCMD(string Command, bool bMobile, bool bPC, bool bOnlyForLowMemory, FConditionalCMDQualityLevel QualityLevelConditional, bool bSetByConsole)
		{
			this.Command = Command;
			this.bMobile = bMobile;
			this.bPC = bPC;
			this.bOnlyForLowMemory = bOnlyForLowMemory;
			this.QualityLevelConditional = QualityLevelConditional;
			this.bSetByConsole = bSetByConsole;
		}

		// Token: 0x06018FDB RID: 102363 RVA: 0x0024F0DA File Offset: 0x0024D2DA
		protected override IntPtr GetUStructPtr()
		{
			return FConditionalCMD.StaticStruct();
		}

		// Token: 0x06018FDC RID: 102364 RVA: 0x0024F0E6 File Offset: 0x0024D2E6
		[NullableContext(2)]
		public FConditionalCMD(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018FDD RID: 102365 RVA: 0x0024F0F0 File Offset: 0x0024D2F0
		public FConditionalCMD(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018FDE RID: 102366 RVA: 0x0024F0FB File Offset: 0x0024D2FB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FConditionalCMD(Pointer, false, true);
		}

		// Token: 0x06018FDF RID: 102367 RVA: 0x0024F105 File Offset: 0x0024D305
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FConditionalCMD(Pointer, MemoryOwner);
		}

		// Token: 0x0400D850 RID: 55376
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.ConditionalCMD";

		// Token: 0x0400D851 RID: 55377
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D852 RID: 55378
		internal static int __PropertyOffset_Command;

		// Token: 0x0400D853 RID: 55379
		internal static int __PropertyOffset_bMobile;

		// Token: 0x0400D854 RID: 55380
		internal static int __PropertyOffset_bPC;

		// Token: 0x0400D855 RID: 55381
		internal static int __PropertyOffset_bOnlyForLowMemory;

		// Token: 0x0400D856 RID: 55382
		internal static int __PropertyOffset_QualityLevelConditional;

		// Token: 0x0400D857 RID: 55383
		[Nullable(2)]
		private FConditionalCMDQualityLevel _QualityLevelConditional;

		// Token: 0x0400D858 RID: 55384
		internal static int __PropertyOffset_bSetByConsole;
	}
}
