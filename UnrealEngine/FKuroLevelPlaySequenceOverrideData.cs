using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019B0 RID: 6576
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroLevelStateMachine.KuroLevelPlaySequenceOverrideData")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FKuroLevelPlaySequenceOverrideData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018771 RID: 100209 RVA: 0x00240D0A File Offset: 0x0023EF0A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroLevelPlaySequenceOverrideData._ScriptStructPtr != 0) ? FKuroLevelPlaySequenceOverrideData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroLevelStateMachine.KuroLevelPlaySequenceOverrideData", ref FKuroLevelPlaySequenceOverrideData._ScriptStructPtr);
		}

		// Token: 0x170061B2 RID: 25010
		// (get) Token: 0x06018772 RID: 100210 RVA: 0x00240D30 File Offset: 0x0023EF30
		// (set) Token: 0x06018773 RID: 100211 RVA: 0x00240D73 File Offset: 0x0023EF73
		public FMovieSceneObjectBindingID ObjectBindingId
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneObjectBindingID result;
				if ((result = this._ObjectBindingId) == null)
				{
					result = (this._ObjectBindingId = new FMovieSceneObjectBindingID(base.NativePtr + (IntPtr)FKuroLevelPlaySequenceOverrideData.__PropertyOffset_ObjectBindingId, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneObjectBindingID.StaticStruct(), base.NativePtr + (IntPtr)FKuroLevelPlaySequenceOverrideData.__PropertyOffset_ObjectBindingId, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170061B3 RID: 25011
		// (get) Token: 0x06018774 RID: 100212 RVA: 0x00240D94 File Offset: 0x0023EF94
		// (set) Token: 0x06018775 RID: 100213 RVA: 0x00240DA8 File Offset: 0x0023EFA8
		[Nullable(2)]
		public unsafe UObject Object
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroLevelPlaySequenceOverrideData.__PropertyOffset_Object);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroLevelPlaySequenceOverrideData.__PropertyOffset_Object, value);
			}
		}

		// Token: 0x170061B4 RID: 25012
		// (get) Token: 0x06018776 RID: 100214 RVA: 0x00240DBD File Offset: 0x0023EFBD
		// (set) Token: 0x06018777 RID: 100215 RVA: 0x00240DCD File Offset: 0x0023EFCD
		public unsafe bool bOverridesDefault
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelPlaySequenceOverrideData.__PropertyOffset_bOverridesDefault) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelPlaySequenceOverrideData.__PropertyOffset_bOverridesDefault) = (value ? 1 : 0);
			}
		}

		// Token: 0x06018778 RID: 100216 RVA: 0x00240DDE File Offset: 0x0023EFDE
		public FKuroLevelPlaySequenceOverrideData()
		{
		}

		// Token: 0x06018779 RID: 100217 RVA: 0x00240DE6 File Offset: 0x0023EFE6
		public FKuroLevelPlaySequenceOverrideData(FMovieSceneObjectBindingID ObjectBindingId, UObject Object, bool bOverridesDefault)
		{
			this.ObjectBindingId = ObjectBindingId;
			this.Object = Object;
			this.bOverridesDefault = bOverridesDefault;
		}

		// Token: 0x0601877A RID: 100218 RVA: 0x00240E03 File Offset: 0x0023F003
		protected override IntPtr GetUStructPtr()
		{
			return FKuroLevelPlaySequenceOverrideData.StaticStruct();
		}

		// Token: 0x0601877B RID: 100219 RVA: 0x00240E0F File Offset: 0x0023F00F
		[NullableContext(2)]
		public FKuroLevelPlaySequenceOverrideData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601877C RID: 100220 RVA: 0x00240E19 File Offset: 0x0023F019
		public FKuroLevelPlaySequenceOverrideData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601877D RID: 100221 RVA: 0x00240E24 File Offset: 0x0023F024
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroLevelPlaySequenceOverrideData(Pointer, false, true);
		}

		// Token: 0x0601877E RID: 100222 RVA: 0x00240E2E File Offset: 0x0023F02E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroLevelPlaySequenceOverrideData(Pointer, MemoryOwner);
		}

		// Token: 0x0400D377 RID: 54135
		public const string __ObjectPath = "/Script/KuroLevelStateMachine.KuroLevelPlaySequenceOverrideData";

		// Token: 0x0400D378 RID: 54136
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D379 RID: 54137
		internal static int __PropertyOffset_ObjectBindingId;

		// Token: 0x0400D37A RID: 54138
		[Nullable(2)]
		private FMovieSceneObjectBindingID _ObjectBindingId;

		// Token: 0x0400D37B RID: 54139
		internal static int __PropertyOffset_Object;

		// Token: 0x0400D37C RID: 54140
		internal static int __PropertyOffset_bOverridesDefault;
	}
}
