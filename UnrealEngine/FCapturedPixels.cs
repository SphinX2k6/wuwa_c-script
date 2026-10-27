using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022FE RID: 8958
	[UnrealObjectPath("/Script/MovieSceneCapture.CapturedPixels")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FCapturedPixels : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021F29 RID: 139049 RVA: 0x00323492 File Offset: 0x00321692
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCapturedPixels._ScriptStructPtr != 0) ? FCapturedPixels._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneCapture.CapturedPixels", ref FCapturedPixels._ScriptStructPtr);
		}

		// Token: 0x06021F2A RID: 139050 RVA: 0x003234B6 File Offset: 0x003216B6
		public FCapturedPixels()
		{
		}

		// Token: 0x06021F2B RID: 139051 RVA: 0x003234BE File Offset: 0x003216BE
		protected override IntPtr GetUStructPtr()
		{
			return FCapturedPixels.StaticStruct();
		}

		// Token: 0x06021F2C RID: 139052 RVA: 0x003234CA File Offset: 0x003216CA
		[NullableContext(2)]
		public FCapturedPixels(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021F2D RID: 139053 RVA: 0x003234D4 File Offset: 0x003216D4
		public FCapturedPixels(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021F2E RID: 139054 RVA: 0x003234DF File Offset: 0x003216DF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCapturedPixels(Pointer, false, true);
		}

		// Token: 0x06021F2F RID: 139055 RVA: 0x003234E9 File Offset: 0x003216E9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCapturedPixels(Pointer, MemoryOwner);
		}

		// Token: 0x040121B7 RID: 74167
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieSceneCapture.CapturedPixels";

		// Token: 0x040121B8 RID: 74168
		private static IntPtr _ScriptStructPtr;
	}
}
