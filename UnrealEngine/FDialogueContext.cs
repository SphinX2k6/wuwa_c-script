using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009BB RID: 2491
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DialogueContext")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FDialogueContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008CAE RID: 36014 RVA: 0x000C956A File Offset: 0x000C776A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDialogueContext._ScriptStructPtr != 0) ? FDialogueContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DialogueContext", ref FDialogueContext._ScriptStructPtr);
		}

		// Token: 0x17002116 RID: 8470
		// (get) Token: 0x06008CAF RID: 36015 RVA: 0x000C958E File Offset: 0x000C778E
		// (set) Token: 0x06008CB0 RID: 36016 RVA: 0x000C95A2 File Offset: 0x000C77A2
		[Nullable(2)]
		public unsafe UDialogueVoice Speaker
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDialogueVoice>(base.NativePtr / (IntPtr)sizeof(void*) + FDialogueContext.__PropertyOffset_Speaker);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FDialogueContext.__PropertyOffset_Speaker, value);
			}
		}

		// Token: 0x17002117 RID: 8471
		// (get) Token: 0x06008CB1 RID: 36017 RVA: 0x000C95B8 File Offset: 0x000C77B8
		// (set) Token: 0x06008CB2 RID: 36018 RVA: 0x000C95FB File Offset: 0x000C77FB
		public TArray<UDialogueVoice> Targets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UDialogueVoice> result;
				if ((result = this._Targets) == null)
				{
					result = (this._Targets = new TArray<UDialogueVoice>(base.NativePtr + (IntPtr)FDialogueContext.__PropertyOffset_Targets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Targets.CopyAssign(value);
			}
		}

		// Token: 0x06008CB3 RID: 36019 RVA: 0x000C9609 File Offset: 0x000C7809
		public FDialogueContext()
		{
		}

		// Token: 0x06008CB4 RID: 36020 RVA: 0x000C9611 File Offset: 0x000C7811
		public FDialogueContext(UDialogueVoice Speaker, TArray<UDialogueVoice> Targets)
		{
			this.Speaker = Speaker;
			this.Targets = Targets;
		}

		// Token: 0x06008CB5 RID: 36021 RVA: 0x000C9627 File Offset: 0x000C7827
		protected override IntPtr GetUStructPtr()
		{
			return FDialogueContext.StaticStruct();
		}

		// Token: 0x06008CB6 RID: 36022 RVA: 0x000C9633 File Offset: 0x000C7833
		[NullableContext(2)]
		public FDialogueContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008CB7 RID: 36023 RVA: 0x000C963D File Offset: 0x000C783D
		public FDialogueContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008CB8 RID: 36024 RVA: 0x000C9648 File Offset: 0x000C7848
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDialogueContext(Pointer, false, true);
		}

		// Token: 0x06008CB9 RID: 36025 RVA: 0x000C9652 File Offset: 0x000C7852
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDialogueContext(Pointer, MemoryOwner);
		}

		// Token: 0x040042CD RID: 17101
		public const string __ObjectPath = "/Script/Engine.DialogueContext";

		// Token: 0x040042CE RID: 17102
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040042CF RID: 17103
		internal static int __PropertyOffset_Speaker;

		// Token: 0x040042D0 RID: 17104
		internal static int __PropertyOffset_Targets;

		// Token: 0x040042D1 RID: 17105
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UDialogueVoice> _Targets;
	}
}
