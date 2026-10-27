using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009C0 RID: 2496
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DialogueWaveParameter")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FDialogueWaveParameter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008CEB RID: 36075 RVA: 0x000C9B0F File Offset: 0x000C7D0F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDialogueWaveParameter._ScriptStructPtr != 0) ? FDialogueWaveParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DialogueWaveParameter", ref FDialogueWaveParameter._ScriptStructPtr);
		}

		// Token: 0x17002125 RID: 8485
		// (get) Token: 0x06008CEC RID: 36076 RVA: 0x000C9B33 File Offset: 0x000C7D33
		// (set) Token: 0x06008CED RID: 36077 RVA: 0x000C9B47 File Offset: 0x000C7D47
		[Nullable(2)]
		public unsafe UDialogueWave DialogueWave
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDialogueWave>(base.NativePtr / (IntPtr)sizeof(void*) + FDialogueWaveParameter.__PropertyOffset_DialogueWave);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FDialogueWaveParameter.__PropertyOffset_DialogueWave, value);
			}
		}

		// Token: 0x17002126 RID: 8486
		// (get) Token: 0x06008CEE RID: 36078 RVA: 0x000C9B5C File Offset: 0x000C7D5C
		// (set) Token: 0x06008CEF RID: 36079 RVA: 0x000C9B9F File Offset: 0x000C7D9F
		public FDialogueContext Context
		{
			get
			{
				base.FastCheckIsValid();
				FDialogueContext result;
				if ((result = this._Context) == null)
				{
					result = (this._Context = new FDialogueContext(base.NativePtr + (IntPtr)FDialogueWaveParameter.__PropertyOffset_Context, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDialogueContext.StaticStruct(), base.NativePtr + (IntPtr)FDialogueWaveParameter.__PropertyOffset_Context, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06008CF0 RID: 36080 RVA: 0x000C9BC0 File Offset: 0x000C7DC0
		public FDialogueWaveParameter()
		{
		}

		// Token: 0x06008CF1 RID: 36081 RVA: 0x000C9BC8 File Offset: 0x000C7DC8
		public FDialogueWaveParameter(UDialogueWave DialogueWave, FDialogueContext Context)
		{
			this.DialogueWave = DialogueWave;
			this.Context = Context;
		}

		// Token: 0x06008CF2 RID: 36082 RVA: 0x000C9BDE File Offset: 0x000C7DDE
		protected override IntPtr GetUStructPtr()
		{
			return FDialogueWaveParameter.StaticStruct();
		}

		// Token: 0x06008CF3 RID: 36083 RVA: 0x000C9BEA File Offset: 0x000C7DEA
		[NullableContext(2)]
		public FDialogueWaveParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008CF4 RID: 36084 RVA: 0x000C9BF4 File Offset: 0x000C7DF4
		public FDialogueWaveParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008CF5 RID: 36085 RVA: 0x000C9BFF File Offset: 0x000C7DFF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDialogueWaveParameter(Pointer, false, true);
		}

		// Token: 0x06008CF6 RID: 36086 RVA: 0x000C9C09 File Offset: 0x000C7E09
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDialogueWaveParameter(Pointer, MemoryOwner);
		}

		// Token: 0x040042EE RID: 17134
		public const string __ObjectPath = "/Script/Engine.DialogueWaveParameter";

		// Token: 0x040042EF RID: 17135
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040042F0 RID: 17136
		internal static int __PropertyOffset_DialogueWave;

		// Token: 0x040042F1 RID: 17137
		internal static int __PropertyOffset_Context;

		// Token: 0x040042F2 RID: 17138
		[Nullable(2)]
		private FDialogueContext _Context;
	}
}
