using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200041B RID: 1051
	[UnrealObjectPath("/Script/KuroGameplay.SequencerBindingRuntimeProxy")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FSequencerBindingRuntimeProxy : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060065CC RID: 26060 RVA: 0x00091C61 File Offset: 0x0008FE61
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSequencerBindingRuntimeProxy._ScriptStructPtr != 0) ? FSequencerBindingRuntimeProxy._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.SequencerBindingRuntimeProxy", ref FSequencerBindingRuntimeProxy._ScriptStructPtr);
		}

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x060065CD RID: 26061 RVA: 0x00091C85 File Offset: 0x0008FE85
		// (set) Token: 0x060065CE RID: 26062 RVA: 0x00091C99 File Offset: 0x0008FE99
		public unsafe FGuid BindingID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSequencerBindingRuntimeProxy.__PropertyOffset_BindingID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSequencerBindingRuntimeProxy.__PropertyOffset_BindingID) = value;
			}
		}

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x060065CF RID: 26063 RVA: 0x00091CAE File Offset: 0x0008FEAE
		// (set) Token: 0x060065D0 RID: 26064 RVA: 0x00091CC2 File Offset: 0x0008FEC2
		[Nullable(2)]
		public unsafe UMovieSceneSequence Sequence
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneSequence>(base.NativePtr / (IntPtr)sizeof(void*) + FSequencerBindingRuntimeProxy.__PropertyOffset_Sequence);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSequencerBindingRuntimeProxy.__PropertyOffset_Sequence, value);
			}
		}

		// Token: 0x060065D1 RID: 26065 RVA: 0x00091CD7 File Offset: 0x0008FED7
		public FSequencerBindingRuntimeProxy()
		{
		}

		// Token: 0x060065D2 RID: 26066 RVA: 0x00091CDF File Offset: 0x0008FEDF
		protected override IntPtr GetUStructPtr()
		{
			return FSequencerBindingRuntimeProxy.StaticStruct();
		}

		// Token: 0x060065D3 RID: 26067 RVA: 0x00091CEB File Offset: 0x0008FEEB
		[NullableContext(2)]
		public FSequencerBindingRuntimeProxy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060065D4 RID: 26068 RVA: 0x00091CF5 File Offset: 0x0008FEF5
		public FSequencerBindingRuntimeProxy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060065D5 RID: 26069 RVA: 0x00091D00 File Offset: 0x0008FF00
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSequencerBindingRuntimeProxy(Pointer, false, true);
		}

		// Token: 0x060065D6 RID: 26070 RVA: 0x00091D0A File Offset: 0x0008FF0A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSequencerBindingRuntimeProxy(Pointer, MemoryOwner);
		}

		// Token: 0x04002AD4 RID: 10964
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.SequencerBindingRuntimeProxy";

		// Token: 0x04002AD5 RID: 10965
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002AD6 RID: 10966
		internal static int __PropertyOffset_BindingID;

		// Token: 0x04002AD7 RID: 10967
		internal static int __PropertyOffset_Sequence;
	}
}
