using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002AC RID: 684
	[UnrealObjectPath("/Script/Engine.VertexOffsetUsage")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FVertexOffsetUsage : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004A27 RID: 18983 RVA: 0x00067DF3 File Offset: 0x00065FF3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVertexOffsetUsage._ScriptStructPtr != 0) ? FVertexOffsetUsage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.VertexOffsetUsage", ref FVertexOffsetUsage._ScriptStructPtr);
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06004A28 RID: 18984 RVA: 0x00067E17 File Offset: 0x00066017
		// (set) Token: 0x06004A29 RID: 18985 RVA: 0x00067E27 File Offset: 0x00066027
		public unsafe int Usage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVertexOffsetUsage.__PropertyOffset_Usage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVertexOffsetUsage.__PropertyOffset_Usage) = value;
			}
		}

		// Token: 0x06004A2A RID: 18986 RVA: 0x00067E38 File Offset: 0x00066038
		public FVertexOffsetUsage()
		{
		}

		// Token: 0x06004A2B RID: 18987 RVA: 0x00067E40 File Offset: 0x00066040
		protected override IntPtr GetUStructPtr()
		{
			return FVertexOffsetUsage.StaticStruct();
		}

		// Token: 0x06004A2C RID: 18988 RVA: 0x00067E4C File Offset: 0x0006604C
		[NullableContext(2)]
		public FVertexOffsetUsage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004A2D RID: 18989 RVA: 0x00067E56 File Offset: 0x00066056
		public FVertexOffsetUsage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004A2E RID: 18990 RVA: 0x00067E61 File Offset: 0x00066061
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVertexOffsetUsage(Pointer, false, true);
		}

		// Token: 0x06004A2F RID: 18991 RVA: 0x00067E6B File Offset: 0x0006606B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVertexOffsetUsage(Pointer, MemoryOwner);
		}

		// Token: 0x04001D39 RID: 7481
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.VertexOffsetUsage";

		// Token: 0x04001D3A RID: 7482
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001D3B RID: 7483
		internal static int __PropertyOffset_Usage;
	}
}
