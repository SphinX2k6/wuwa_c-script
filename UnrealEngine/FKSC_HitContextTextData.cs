using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001DEC RID: 7660
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_HitContextTextData")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKSC_HitContextTextData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D472 RID: 119922 RVA: 0x002B3B94 File Offset: 0x002B1D94
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_HitContextTextData._ScriptStructPtr != 0) ? FKSC_HitContextTextData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_HitContextTextData", ref FKSC_HitContextTextData._ScriptStructPtr);
		}

		// Token: 0x1700763E RID: 30270
		// (get) Token: 0x0601D473 RID: 119923 RVA: 0x002B3BB8 File Offset: 0x002B1DB8
		// (set) Token: 0x0601D474 RID: 119924 RVA: 0x002B3BC8 File Offset: 0x002B1DC8
		public unsafe int HitContextStyleId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HitContextTextData.__PropertyOffset_HitContextStyleId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HitContextTextData.__PropertyOffset_HitContextStyleId) = value;
			}
		}

		// Token: 0x1700763F RID: 30271
		// (get) Token: 0x0601D475 RID: 119925 RVA: 0x002B3BD9 File Offset: 0x002B1DD9
		// (set) Token: 0x0601D476 RID: 119926 RVA: 0x002B3BED File Offset: 0x002B1DED
		public unsafe string TextContent
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKSC_HitContextTextData.__PropertyOffset_TextContent)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKSC_HitContextTextData.__PropertyOffset_TextContent)), value);
			}
		}

		// Token: 0x17007640 RID: 30272
		// (get) Token: 0x0601D477 RID: 119927 RVA: 0x002B3C02 File Offset: 0x002B1E02
		// (set) Token: 0x0601D478 RID: 119928 RVA: 0x002B3C12 File Offset: 0x002B1E12
		public unsafe float CooldownSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HitContextTextData.__PropertyOffset_CooldownSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HitContextTextData.__PropertyOffset_CooldownSeconds) = value;
			}
		}

		// Token: 0x0601D479 RID: 119929 RVA: 0x002B3C23 File Offset: 0x002B1E23
		public FKSC_HitContextTextData()
		{
		}

		// Token: 0x0601D47A RID: 119930 RVA: 0x002B3C2B File Offset: 0x002B1E2B
		public FKSC_HitContextTextData(int HitContextStyleId, string TextContent, float CooldownSeconds)
		{
			this.HitContextStyleId = HitContextStyleId;
			this.TextContent = TextContent;
			this.CooldownSeconds = CooldownSeconds;
		}

		// Token: 0x0601D47B RID: 119931 RVA: 0x002B3C48 File Offset: 0x002B1E48
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_HitContextTextData.StaticStruct();
		}

		// Token: 0x0601D47C RID: 119932 RVA: 0x002B3C54 File Offset: 0x002B1E54
		[NullableContext(2)]
		public FKSC_HitContextTextData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D47D RID: 119933 RVA: 0x002B3C5E File Offset: 0x002B1E5E
		public FKSC_HitContextTextData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D47E RID: 119934 RVA: 0x002B3C69 File Offset: 0x002B1E69
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_HitContextTextData(Pointer, false, true);
		}

		// Token: 0x0601D47F RID: 119935 RVA: 0x002B3C73 File Offset: 0x002B1E73
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_HitContextTextData(Pointer, MemoryOwner);
		}

		// Token: 0x0400FE34 RID: 65076
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_HitContextTextData";

		// Token: 0x0400FE35 RID: 65077
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FE36 RID: 65078
		internal static int __PropertyOffset_HitContextStyleId;

		// Token: 0x0400FE37 RID: 65079
		internal static int __PropertyOffset_TextContent;

		// Token: 0x0400FE38 RID: 65080
		internal static int __PropertyOffset_CooldownSeconds;
	}
}
