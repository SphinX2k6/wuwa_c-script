using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001704 RID: 5892
	[UnrealObjectPath("/Script/KuroBulletCore.KuroForeverTimeScale")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroForeverTimeScale : FKuroTimeScaleBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601546F RID: 87151 RVA: 0x001F4597 File Offset: 0x001F2797
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroForeverTimeScale._ScriptStructPtr != 0) ? FKuroForeverTimeScale._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.KuroForeverTimeScale", ref FKuroForeverTimeScale._ScriptStructPtr);
		}

		// Token: 0x06015470 RID: 87152 RVA: 0x001F45BB File Offset: 0x001F27BB
		public FKuroForeverTimeScale()
		{
		}

		// Token: 0x06015471 RID: 87153 RVA: 0x001F45C3 File Offset: 0x001F27C3
		protected override IntPtr GetUStructPtr()
		{
			return FKuroForeverTimeScale.StaticStruct();
		}

		// Token: 0x06015472 RID: 87154 RVA: 0x001F45CF File Offset: 0x001F27CF
		[NullableContext(2)]
		public FKuroForeverTimeScale(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015473 RID: 87155 RVA: 0x001F45D9 File Offset: 0x001F27D9
		public FKuroForeverTimeScale(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015474 RID: 87156 RVA: 0x001F45E4 File Offset: 0x001F27E4
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroForeverTimeScale(Pointer, false, true);
		}

		// Token: 0x06015475 RID: 87157 RVA: 0x001F45EE File Offset: 0x001F27EE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroForeverTimeScale(Pointer, MemoryOwner);
		}

		// Token: 0x0400B99D RID: 47517
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroForeverTimeScale";

		// Token: 0x0400B99E RID: 47518
		private static IntPtr _ScriptStructPtr;
	}
}
