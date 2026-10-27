using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E31 RID: 7729
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2D_CollisionListenContext")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKSC_Shape2D_CollisionListenContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D738 RID: 120632 RVA: 0x002B7F98 File Offset: 0x002B6198
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_Shape2D_CollisionListenContext._ScriptStructPtr != 0) ? FKSC_Shape2D_CollisionListenContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_Shape2D_CollisionListenContext", ref FKSC_Shape2D_CollisionListenContext._ScriptStructPtr);
		}

		// Token: 0x170076B5 RID: 30389
		// (get) Token: 0x0601D739 RID: 120633 RVA: 0x002B7FBC File Offset: 0x002B61BC
		// (set) Token: 0x0601D73A RID: 120634 RVA: 0x002B7FD0 File Offset: 0x002B61D0
		[Nullable(2)]
		public unsafe UObject Target
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_Shape2D_CollisionListenContext.__PropertyOffset_Target);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_Shape2D_CollisionListenContext.__PropertyOffset_Target, value);
			}
		}

		// Token: 0x0601D73B RID: 120635 RVA: 0x002B7FE5 File Offset: 0x002B61E5
		public FKSC_Shape2D_CollisionListenContext()
		{
		}

		// Token: 0x0601D73C RID: 120636 RVA: 0x002B7FED File Offset: 0x002B61ED
		[NullableContext(1)]
		public FKSC_Shape2D_CollisionListenContext(UObject Target)
		{
			this.Target = Target;
		}

		// Token: 0x0601D73D RID: 120637 RVA: 0x002B7FFC File Offset: 0x002B61FC
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_Shape2D_CollisionListenContext.StaticStruct();
		}

		// Token: 0x0601D73E RID: 120638 RVA: 0x002B8008 File Offset: 0x002B6208
		[NullableContext(2)]
		public FKSC_Shape2D_CollisionListenContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D73F RID: 120639 RVA: 0x002B8012 File Offset: 0x002B6212
		public FKSC_Shape2D_CollisionListenContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D740 RID: 120640 RVA: 0x002B801D File Offset: 0x002B621D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_Shape2D_CollisionListenContext(Pointer, false, true);
		}

		// Token: 0x0601D741 RID: 120641 RVA: 0x002B8027 File Offset: 0x002B6227
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_Shape2D_CollisionListenContext(Pointer, MemoryOwner);
		}

		// Token: 0x0400FF84 RID: 65412
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2D_CollisionListenContext";

		// Token: 0x0400FF85 RID: 65413
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FF86 RID: 65414
		internal static int __PropertyOffset_Target;
	}
}
