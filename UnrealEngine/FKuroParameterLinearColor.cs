using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020018FE RID: 6398
	[UnrealObjectPath("/Script/KuroGameplay.KuroParameterLinearColor")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FKuroParameterLinearColor : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017BE2 RID: 97250 RVA: 0x0022C94F File Offset: 0x0022AB4F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroParameterLinearColor._ScriptStructPtr != 0) ? FKuroParameterLinearColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroParameterLinearColor", ref FKuroParameterLinearColor._ScriptStructPtr);
		}

		// Token: 0x17005F9E RID: 24478
		// (get) Token: 0x06017BE3 RID: 97251 RVA: 0x0022C973 File Offset: 0x0022AB73
		// (set) Token: 0x06017BE4 RID: 97252 RVA: 0x0022C987 File Offset: 0x0022AB87
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroParameterLinearColor.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroParameterLinearColor.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17005F9F RID: 24479
		// (get) Token: 0x06017BE5 RID: 97253 RVA: 0x0022C99C File Offset: 0x0022AB9C
		// (set) Token: 0x06017BE6 RID: 97254 RVA: 0x0022C9B0 File Offset: 0x0022ABB0
		public unsafe FLinearColor Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroParameterLinearColor.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroParameterLinearColor.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x06017BE7 RID: 97255 RVA: 0x0022C9C5 File Offset: 0x0022ABC5
		public FKuroParameterLinearColor()
		{
		}

		// Token: 0x06017BE8 RID: 97256 RVA: 0x0022C9CD File Offset: 0x0022ABCD
		public FKuroParameterLinearColor(FName Name, FLinearColor Value)
		{
			this.Name = Name;
			this.Value = Value;
		}

		// Token: 0x06017BE9 RID: 97257 RVA: 0x0022C9E3 File Offset: 0x0022ABE3
		protected override IntPtr GetUStructPtr()
		{
			return FKuroParameterLinearColor.StaticStruct();
		}

		// Token: 0x06017BEA RID: 97258 RVA: 0x0022C9EF File Offset: 0x0022ABEF
		[NullableContext(2)]
		public FKuroParameterLinearColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017BEB RID: 97259 RVA: 0x0022C9F9 File Offset: 0x0022ABF9
		public FKuroParameterLinearColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017BEC RID: 97260 RVA: 0x0022CA04 File Offset: 0x0022AC04
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroParameterLinearColor(Pointer, false, true);
		}

		// Token: 0x06017BED RID: 97261 RVA: 0x0022CA0E File Offset: 0x0022AC0E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroParameterLinearColor(Pointer, MemoryOwner);
		}

		// Token: 0x0400CE25 RID: 52773
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroParameterLinearColor";

		// Token: 0x0400CE26 RID: 52774
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CE27 RID: 52775
		internal static int __PropertyOffset_Name;

		// Token: 0x0400CE28 RID: 52776
		internal static int __PropertyOffset_Value;
	}
}
