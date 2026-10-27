using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000980 RID: 2432
	[UnrealObjectPath("/Script/Engine.CurveMetaData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FCurveMetaData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600899A RID: 35226 RVA: 0x000C5171 File Offset: 0x000C3371
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCurveMetaData._ScriptStructPtr != 0) ? FCurveMetaData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CurveMetaData", ref FCurveMetaData._ScriptStructPtr);
		}

		// Token: 0x0600899B RID: 35227 RVA: 0x000C5195 File Offset: 0x000C3395
		public FCurveMetaData()
		{
		}

		// Token: 0x0600899C RID: 35228 RVA: 0x000C519D File Offset: 0x000C339D
		protected override IntPtr GetUStructPtr()
		{
			return FCurveMetaData.StaticStruct();
		}

		// Token: 0x0600899D RID: 35229 RVA: 0x000C51A9 File Offset: 0x000C33A9
		[NullableContext(2)]
		public FCurveMetaData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600899E RID: 35230 RVA: 0x000C51B3 File Offset: 0x000C33B3
		public FCurveMetaData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600899F RID: 35231 RVA: 0x000C51BE File Offset: 0x000C33BE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCurveMetaData(Pointer, false, true);
		}

		// Token: 0x060089A0 RID: 35232 RVA: 0x000C51C8 File Offset: 0x000C33C8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCurveMetaData(Pointer, MemoryOwner);
		}

		// Token: 0x0400415C RID: 16732
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CurveMetaData";

		// Token: 0x0400415D RID: 16733
		private static IntPtr _ScriptStructPtr;
	}
}
