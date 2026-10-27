using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CE3 RID: 3299
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroBaseFolderCheckConfig")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroBaseFolderCheckConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AF05 RID: 44805 RVA: 0x000F84A8 File Offset: 0x000F66A8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBaseFolderCheckConfig._ScriptStructPtr != 0) ? FKuroBaseFolderCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroBaseFolderCheckConfig", ref FKuroBaseFolderCheckConfig._ScriptStructPtr);
		}

		// Token: 0x1700278B RID: 10123
		// (get) Token: 0x0600AF06 RID: 44806 RVA: 0x000F84CC File Offset: 0x000F66CC
		// (set) Token: 0x0600AF07 RID: 44807 RVA: 0x000F84E0 File Offset: 0x000F66E0
		public unsafe string Regex
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroBaseFolderCheckConfig.__PropertyOffset_Regex)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroBaseFolderCheckConfig.__PropertyOffset_Regex)), value);
			}
		}

		// Token: 0x1700278C RID: 10124
		// (get) Token: 0x0600AF08 RID: 44808 RVA: 0x000F84F5 File Offset: 0x000F66F5
		// (set) Token: 0x0600AF09 RID: 44809 RVA: 0x000F8505 File Offset: 0x000F6705
		public unsafe int MatchingPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBaseFolderCheckConfig.__PropertyOffset_MatchingPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBaseFolderCheckConfig.__PropertyOffset_MatchingPriority) = value;
			}
		}

		// Token: 0x0600AF0A RID: 44810 RVA: 0x000F8516 File Offset: 0x000F6716
		public FKuroBaseFolderCheckConfig()
		{
		}

		// Token: 0x0600AF0B RID: 44811 RVA: 0x000F851E File Offset: 0x000F671E
		public FKuroBaseFolderCheckConfig(string Regex, int MatchingPriority)
		{
			this.Regex = Regex;
			this.MatchingPriority = MatchingPriority;
		}

		// Token: 0x0600AF0C RID: 44812 RVA: 0x000F8534 File Offset: 0x000F6734
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBaseFolderCheckConfig.StaticStruct();
		}

		// Token: 0x0600AF0D RID: 44813 RVA: 0x000F8540 File Offset: 0x000F6740
		[NullableContext(2)]
		public FKuroBaseFolderCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AF0E RID: 44814 RVA: 0x000F854A File Offset: 0x000F674A
		public FKuroBaseFolderCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AF0F RID: 44815 RVA: 0x000F8555 File Offset: 0x000F6755
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBaseFolderCheckConfig(Pointer, false, true);
		}

		// Token: 0x0600AF10 RID: 44816 RVA: 0x000F855F File Offset: 0x000F675F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBaseFolderCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04005BAC RID: 23468
		public const string __ObjectPath = "/Script/Engine.KuroBaseFolderCheckConfig";

		// Token: 0x04005BAD RID: 23469
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005BAE RID: 23470
		internal static int __PropertyOffset_Regex;

		// Token: 0x04005BAF RID: 23471
		internal static int __PropertyOffset_MatchingPriority;
	}
}
