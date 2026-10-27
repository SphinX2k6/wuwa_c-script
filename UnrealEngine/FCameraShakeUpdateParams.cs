using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000916 RID: 2326
	[UnrealObjectPath("/Script/Engine.CameraShakeUpdateParams")]
	[UnrealStructLayout(2752, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2752)]
	public class FCameraShakeUpdateParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008006 RID: 32774 RVA: 0x000B76A7 File Offset: 0x000B58A7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCameraShakeUpdateParams._ScriptStructPtr != 0) ? FCameraShakeUpdateParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CameraShakeUpdateParams", ref FCameraShakeUpdateParams._ScriptStructPtr);
		}

		// Token: 0x06008007 RID: 32775 RVA: 0x000B76CB File Offset: 0x000B58CB
		public FCameraShakeUpdateParams()
		{
		}

		// Token: 0x06008008 RID: 32776 RVA: 0x000B76D3 File Offset: 0x000B58D3
		protected override IntPtr GetUStructPtr()
		{
			return FCameraShakeUpdateParams.StaticStruct();
		}

		// Token: 0x06008009 RID: 32777 RVA: 0x000B76DF File Offset: 0x000B58DF
		[NullableContext(2)]
		public FCameraShakeUpdateParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600800A RID: 32778 RVA: 0x000B76E9 File Offset: 0x000B58E9
		public FCameraShakeUpdateParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600800B RID: 32779 RVA: 0x000B76F4 File Offset: 0x000B58F4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCameraShakeUpdateParams(Pointer, false, true);
		}

		// Token: 0x0600800C RID: 32780 RVA: 0x000B76FE File Offset: 0x000B58FE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCameraShakeUpdateParams(Pointer, MemoryOwner);
		}

		// Token: 0x04003D5B RID: 15707
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CameraShakeUpdateParams";

		// Token: 0x04003D5C RID: 15708
		private static IntPtr _ScriptStructPtr;
	}
}
