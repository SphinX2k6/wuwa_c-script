using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200199A RID: 6554
	[UnrealObjectPath("/Script/KuroInteractionEffect.IEMeshBoxShape")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FIEMeshBoxShape : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018599 RID: 99737 RVA: 0x0023E6FE File Offset: 0x0023C8FE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIEMeshBoxShape._ScriptStructPtr != 0) ? FIEMeshBoxShape._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroInteractionEffect.IEMeshBoxShape", ref FIEMeshBoxShape._ScriptStructPtr);
		}

		// Token: 0x17006128 RID: 24872
		// (get) Token: 0x0601859A RID: 99738 RVA: 0x0023E722 File Offset: 0x0023C922
		// (set) Token: 0x0601859B RID: 99739 RVA: 0x0023E736 File Offset: 0x0023C936
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshBoxShape.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshBoxShape.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x17006129 RID: 24873
		// (get) Token: 0x0601859C RID: 99740 RVA: 0x0023E74B File Offset: 0x0023C94B
		// (set) Token: 0x0601859D RID: 99741 RVA: 0x0023E75F File Offset: 0x0023C95F
		public unsafe FVector HalfExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshBoxShape.__PropertyOffset_HalfExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshBoxShape.__PropertyOffset_HalfExtent) = value;
			}
		}

		// Token: 0x0601859E RID: 99742 RVA: 0x0023E774 File Offset: 0x0023C974
		public FIEMeshBoxShape()
		{
		}

		// Token: 0x0601859F RID: 99743 RVA: 0x0023E77C File Offset: 0x0023C97C
		public FIEMeshBoxShape(FVector Center, FVector HalfExtent)
		{
			this.Center = Center;
			this.HalfExtent = HalfExtent;
		}

		// Token: 0x060185A0 RID: 99744 RVA: 0x0023E792 File Offset: 0x0023C992
		protected override IntPtr GetUStructPtr()
		{
			return FIEMeshBoxShape.StaticStruct();
		}

		// Token: 0x060185A1 RID: 99745 RVA: 0x0023E79E File Offset: 0x0023C99E
		[NullableContext(2)]
		public FIEMeshBoxShape(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060185A2 RID: 99746 RVA: 0x0023E7A8 File Offset: 0x0023C9A8
		public FIEMeshBoxShape(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060185A3 RID: 99747 RVA: 0x0023E7B3 File Offset: 0x0023C9B3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FIEMeshBoxShape(Pointer, false, true);
		}

		// Token: 0x060185A4 RID: 99748 RVA: 0x0023E7BD File Offset: 0x0023C9BD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FIEMeshBoxShape(Pointer, MemoryOwner);
		}

		// Token: 0x0400D2AA RID: 53930
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroInteractionEffect.IEMeshBoxShape";

		// Token: 0x0400D2AB RID: 53931
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D2AC RID: 53932
		internal static int __PropertyOffset_Center;

		// Token: 0x0400D2AD RID: 53933
		internal static int __PropertyOffset_HalfExtent;
	}
}
