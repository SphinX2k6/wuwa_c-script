using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012F4 RID: 4852
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTaskDebugMessage")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FAbilityTaskDebugMessage : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011DF8 RID: 73208 RVA: 0x001A3745 File Offset: 0x001A1945
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAbilityTaskDebugMessage._ScriptStructPtr != 0) ? FAbilityTaskDebugMessage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.AbilityTaskDebugMessage", ref FAbilityTaskDebugMessage._ScriptStructPtr);
		}

		// Token: 0x170045CE RID: 17870
		// (get) Token: 0x06011DF9 RID: 73209 RVA: 0x001A3769 File Offset: 0x001A1969
		// (set) Token: 0x06011DFA RID: 73210 RVA: 0x001A377D File Offset: 0x001A197D
		[Nullable(2)]
		public unsafe UGameplayTask FromTask
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayTask>(base.NativePtr / (IntPtr)sizeof(void*) + FAbilityTaskDebugMessage.__PropertyOffset_FromTask);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAbilityTaskDebugMessage.__PropertyOffset_FromTask, value);
			}
		}

		// Token: 0x170045CF RID: 17871
		// (get) Token: 0x06011DFB RID: 73211 RVA: 0x001A3792 File Offset: 0x001A1992
		// (set) Token: 0x06011DFC RID: 73212 RVA: 0x001A37A6 File Offset: 0x001A19A6
		public unsafe string Message
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAbilityTaskDebugMessage.__PropertyOffset_Message)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAbilityTaskDebugMessage.__PropertyOffset_Message)), value);
			}
		}

		// Token: 0x06011DFD RID: 73213 RVA: 0x001A37BB File Offset: 0x001A19BB
		public FAbilityTaskDebugMessage()
		{
		}

		// Token: 0x06011DFE RID: 73214 RVA: 0x001A37C3 File Offset: 0x001A19C3
		public FAbilityTaskDebugMessage(UGameplayTask FromTask, string Message)
		{
			this.FromTask = FromTask;
			this.Message = Message;
		}

		// Token: 0x06011DFF RID: 73215 RVA: 0x001A37D9 File Offset: 0x001A19D9
		protected override IntPtr GetUStructPtr()
		{
			return FAbilityTaskDebugMessage.StaticStruct();
		}

		// Token: 0x06011E00 RID: 73216 RVA: 0x001A37E5 File Offset: 0x001A19E5
		[NullableContext(2)]
		public FAbilityTaskDebugMessage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011E01 RID: 73217 RVA: 0x001A37EF File Offset: 0x001A19EF
		public FAbilityTaskDebugMessage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011E02 RID: 73218 RVA: 0x001A37FA File Offset: 0x001A19FA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAbilityTaskDebugMessage(Pointer, false, true);
		}

		// Token: 0x06011E03 RID: 73219 RVA: 0x001A3804 File Offset: 0x001A1A04
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAbilityTaskDebugMessage(Pointer, MemoryOwner);
		}

		// Token: 0x040098EB RID: 39147
		public const string __ObjectPath = "/Script/GameplayAbilities.AbilityTaskDebugMessage";

		// Token: 0x040098EC RID: 39148
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040098ED RID: 39149
		internal static int __PropertyOffset_FromTask;

		// Token: 0x040098EE RID: 39150
		internal static int __PropertyOffset_Message;
	}
}
