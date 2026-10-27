using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BFE RID: 3070
	[UnrealObjectPath("/Script/Engine.GameNameRedirect")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FGameNameRedirect : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009821 RID: 38945 RVA: 0x000D8AB4 File Offset: 0x000D6CB4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameNameRedirect._ScriptStructPtr != 0) ? FGameNameRedirect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.GameNameRedirect", ref FGameNameRedirect._ScriptStructPtr);
		}

		// Token: 0x17002466 RID: 9318
		// (get) Token: 0x06009822 RID: 38946 RVA: 0x000D8AD8 File Offset: 0x000D6CD8
		// (set) Token: 0x06009823 RID: 38947 RVA: 0x000D8AEC File Offset: 0x000D6CEC
		public unsafe FName OldGameName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameNameRedirect.__PropertyOffset_OldGameName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameNameRedirect.__PropertyOffset_OldGameName) = value;
			}
		}

		// Token: 0x17002467 RID: 9319
		// (get) Token: 0x06009824 RID: 38948 RVA: 0x000D8B01 File Offset: 0x000D6D01
		// (set) Token: 0x06009825 RID: 38949 RVA: 0x000D8B15 File Offset: 0x000D6D15
		public unsafe FName NewGameName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameNameRedirect.__PropertyOffset_NewGameName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameNameRedirect.__PropertyOffset_NewGameName) = value;
			}
		}

		// Token: 0x06009826 RID: 38950 RVA: 0x000D8B2A File Offset: 0x000D6D2A
		public FGameNameRedirect()
		{
		}

		// Token: 0x06009827 RID: 38951 RVA: 0x000D8B32 File Offset: 0x000D6D32
		public FGameNameRedirect(FName OldGameName, FName NewGameName)
		{
			this.OldGameName = OldGameName;
			this.NewGameName = NewGameName;
		}

		// Token: 0x06009828 RID: 38952 RVA: 0x000D8B48 File Offset: 0x000D6D48
		protected override IntPtr GetUStructPtr()
		{
			return FGameNameRedirect.StaticStruct();
		}

		// Token: 0x06009829 RID: 38953 RVA: 0x000D8B54 File Offset: 0x000D6D54
		[NullableContext(2)]
		public FGameNameRedirect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600982A RID: 38954 RVA: 0x000D8B5E File Offset: 0x000D6D5E
		public FGameNameRedirect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600982B RID: 38955 RVA: 0x000D8B69 File Offset: 0x000D6D69
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameNameRedirect(Pointer, false, true);
		}

		// Token: 0x0600982C RID: 38956 RVA: 0x000D8B73 File Offset: 0x000D6D73
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameNameRedirect(Pointer, MemoryOwner);
		}

		// Token: 0x04005500 RID: 21760
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.GameNameRedirect";

		// Token: 0x04005501 RID: 21761
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005502 RID: 21762
		internal static int __PropertyOffset_OldGameName;

		// Token: 0x04005503 RID: 21763
		internal static int __PropertyOffset_NewGameName;
	}
}
