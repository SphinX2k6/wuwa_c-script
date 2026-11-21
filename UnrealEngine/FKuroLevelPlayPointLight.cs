using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020003F3 RID: 1011
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelPlayPointLight")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroLevelPlayPointLight : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006375 RID: 25461 RVA: 0x0008E369 File Offset: 0x0008C569
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroLevelPlayPointLight._ScriptStructPtr != 0) ? FKuroLevelPlayPointLight._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroLevelPlayPointLight", ref FKuroLevelPlayPointLight._ScriptStructPtr);
		}

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x06006376 RID: 25462 RVA: 0x0008E38D File Offset: 0x0008C58D
		// (set) Token: 0x06006377 RID: 25463 RVA: 0x0008E39D File Offset: 0x0008C59D
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelPlayPointLight.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelPlayPointLight.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x06006378 RID: 25464 RVA: 0x0008E3AE File Offset: 0x0008C5AE
		// (set) Token: 0x06006379 RID: 25465 RVA: 0x0008E3BE File Offset: 0x0008C5BE
		public unsafe bool bLit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelPlayPointLight.__PropertyOffset_bLit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelPlayPointLight.__PropertyOffset_bLit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x0600637A RID: 25466 RVA: 0x0008E3CF File Offset: 0x0008C5CF
		// (set) Token: 0x0600637B RID: 25467 RVA: 0x0008E3E3 File Offset: 0x0008C5E3
		public unsafe FVectorDouble Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelPlayPointLight.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelPlayPointLight.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x0600637C RID: 25468 RVA: 0x0008E3F8 File Offset: 0x0008C5F8
		public FKuroLevelPlayPointLight()
		{
		}

		// Token: 0x0600637D RID: 25469 RVA: 0x0008E400 File Offset: 0x0008C600
		protected override IntPtr GetUStructPtr()
		{
			return FKuroLevelPlayPointLight.StaticStruct();
		}

		// Token: 0x0600637E RID: 25470 RVA: 0x0008E40C File Offset: 0x0008C60C
		[NullableContext(2)]
		public FKuroLevelPlayPointLight(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600637F RID: 25471 RVA: 0x0008E416 File Offset: 0x0008C616
		public FKuroLevelPlayPointLight(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006380 RID: 25472 RVA: 0x0008E421 File Offset: 0x0008C621
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroLevelPlayPointLight(Pointer, false, true);
		}

		// Token: 0x06006381 RID: 25473 RVA: 0x0008E42B File Offset: 0x0008C62B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroLevelPlayPointLight(Pointer, MemoryOwner);
		}

		// Token: 0x04002A08 RID: 10760
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroLevelPlayPointLight";

		// Token: 0x04002A09 RID: 10761
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002A0A RID: 10762
		internal static int __PropertyOffset_Radius;

		// Token: 0x04002A0B RID: 10763
		internal static int __PropertyOffset_bLit;

		// Token: 0x04002A0C RID: 10764
		internal static int __PropertyOffset_Position;
	}
}
