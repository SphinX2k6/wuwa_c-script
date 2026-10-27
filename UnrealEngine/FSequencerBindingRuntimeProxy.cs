using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001939 RID: 6457
	[UnrealObjectPath("/Script/KuroGameplay.SequencerBindingRuntimeProxy")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FSequencerBindingRuntimeProxy : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017F17 RID: 98071 RVA: 0x002314B9 File Offset: 0x0022F6B9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSequencerBindingRuntimeProxy._ScriptStructPtr != 0) ? FSequencerBindingRuntimeProxy._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.SequencerBindingRuntimeProxy", ref FSequencerBindingRuntimeProxy._ScriptStructPtr);
		}

		// Token: 0x17006008 RID: 24584
		// (get) Token: 0x06017F18 RID: 98072 RVA: 0x002314DD File Offset: 0x0022F6DD
		// (set) Token: 0x06017F19 RID: 98073 RVA: 0x002314F1 File Offset: 0x0022F6F1
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

		// Token: 0x17006009 RID: 24585
		// (get) Token: 0x06017F1A RID: 98074 RVA: 0x00231506 File Offset: 0x0022F706
		// (set) Token: 0x06017F1B RID: 98075 RVA: 0x0023151A File Offset: 0x0022F71A
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

		// Token: 0x06017F1C RID: 98076 RVA: 0x0023152F File Offset: 0x0022F72F
		public FSequencerBindingRuntimeProxy()
		{
		}

		// Token: 0x06017F1D RID: 98077 RVA: 0x00231537 File Offset: 0x0022F737
		[NullableContext(1)]
		public FSequencerBindingRuntimeProxy(FGuid BindingID, UMovieSceneSequence Sequence)
		{
			this.BindingID = BindingID;
			this.Sequence = Sequence;
		}

		// Token: 0x06017F1E RID: 98078 RVA: 0x0023154D File Offset: 0x0022F74D
		protected override IntPtr GetUStructPtr()
		{
			return FSequencerBindingRuntimeProxy.StaticStruct();
		}

		// Token: 0x06017F1F RID: 98079 RVA: 0x00231559 File Offset: 0x0022F759
		[NullableContext(2)]
		public FSequencerBindingRuntimeProxy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017F20 RID: 98080 RVA: 0x00231563 File Offset: 0x0022F763
		public FSequencerBindingRuntimeProxy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017F21 RID: 98081 RVA: 0x0023156E File Offset: 0x0022F76E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSequencerBindingRuntimeProxy(Pointer, false, true);
		}

		// Token: 0x06017F22 RID: 98082 RVA: 0x00231578 File Offset: 0x0022F778
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSequencerBindingRuntimeProxy(Pointer, MemoryOwner);
		}

		// Token: 0x0400CF53 RID: 53075
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.SequencerBindingRuntimeProxy";

		// Token: 0x0400CF54 RID: 53076
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CF55 RID: 53077
		internal static int __PropertyOffset_BindingID;

		// Token: 0x0400CF56 RID: 53078
		internal static int __PropertyOffset_Sequence;
	}
}
