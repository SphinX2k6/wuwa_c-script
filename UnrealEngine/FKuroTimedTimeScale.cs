using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001705 RID: 5893
	[UnrealObjectPath("/Script/KuroBulletCore.KuroTimedTimeScale")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FKuroTimedTimeScale : FKuroTimeScaleBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015476 RID: 87158 RVA: 0x001F45F7 File Offset: 0x001F27F7
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroTimedTimeScale._ScriptStructPtr != 0) ? FKuroTimedTimeScale._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.KuroTimedTimeScale", ref FKuroTimedTimeScale._ScriptStructPtr);
		}

		// Token: 0x17005428 RID: 21544
		// (get) Token: 0x06015477 RID: 87159 RVA: 0x001F461B File Offset: 0x001F281B
		// (set) Token: 0x06015478 RID: 87160 RVA: 0x001F462F File Offset: 0x001F282F
		[Nullable(2)]
		public unsafe UCurveFloat Curve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroTimedTimeScale.__PropertyOffset_Curve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroTimedTimeScale.__PropertyOffset_Curve, value);
			}
		}

		// Token: 0x06015479 RID: 87161 RVA: 0x001F4644 File Offset: 0x001F2844
		public FKuroTimedTimeScale()
		{
		}

		// Token: 0x0601547A RID: 87162 RVA: 0x001F464C File Offset: 0x001F284C
		[NullableContext(1)]
		public FKuroTimedTimeScale(UCurveFloat Curve)
		{
			this.Curve = Curve;
		}

		// Token: 0x0601547B RID: 87163 RVA: 0x001F465B File Offset: 0x001F285B
		protected override IntPtr GetUStructPtr()
		{
			return FKuroTimedTimeScale.StaticStruct();
		}

		// Token: 0x0601547C RID: 87164 RVA: 0x001F4667 File Offset: 0x001F2867
		[NullableContext(2)]
		public FKuroTimedTimeScale(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601547D RID: 87165 RVA: 0x001F4671 File Offset: 0x001F2871
		public FKuroTimedTimeScale(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601547E RID: 87166 RVA: 0x001F467C File Offset: 0x001F287C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroTimedTimeScale(Pointer, false, true);
		}

		// Token: 0x0601547F RID: 87167 RVA: 0x001F4686 File Offset: 0x001F2886
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroTimedTimeScale(Pointer, MemoryOwner);
		}

		// Token: 0x0400B99F RID: 47519
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroTimedTimeScale";

		// Token: 0x0400B9A0 RID: 47520
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B9A1 RID: 47521
		internal static int __PropertyOffset_Curve;
	}
}
