using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A79 RID: 10873
	[UnrealObjectPath("/Script/WwiseObjectUtils.AkUInt32Wrapper")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FAkUInt32Wrapper : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028184 RID: 164228 RVA: 0x003D060E File Offset: 0x003CE80E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkUInt32Wrapper._ScriptStructPtr != 0) ? FAkUInt32Wrapper._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseObjectUtils.AkUInt32Wrapper", ref FAkUInt32Wrapper._ScriptStructPtr);
		}

		// Token: 0x1700991A RID: 39194
		// (get) Token: 0x06028185 RID: 164229 RVA: 0x003D0632 File Offset: 0x003CE832
		// (set) Token: 0x06028186 RID: 164230 RVA: 0x003D0642 File Offset: 0x003CE842
		public unsafe uint UInt32Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkUInt32Wrapper.__PropertyOffset_UInt32Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkUInt32Wrapper.__PropertyOffset_UInt32Value) = (int)value;
			}
		}

		// Token: 0x06028187 RID: 164231 RVA: 0x003D0653 File Offset: 0x003CE853
		public FAkUInt32Wrapper()
		{
		}

		// Token: 0x06028188 RID: 164232 RVA: 0x003D065B File Offset: 0x003CE85B
		public FAkUInt32Wrapper(uint UInt32Value)
		{
			this.UInt32Value = UInt32Value;
		}

		// Token: 0x06028189 RID: 164233 RVA: 0x003D066A File Offset: 0x003CE86A
		protected override IntPtr GetUStructPtr()
		{
			return FAkUInt32Wrapper.StaticStruct();
		}

		// Token: 0x0602818A RID: 164234 RVA: 0x003D0676 File Offset: 0x003CE876
		[NullableContext(2)]
		public FAkUInt32Wrapper(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602818B RID: 164235 RVA: 0x003D0680 File Offset: 0x003CE880
		public FAkUInt32Wrapper(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602818C RID: 164236 RVA: 0x003D068B File Offset: 0x003CE88B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkUInt32Wrapper(Pointer, false, true);
		}

		// Token: 0x0602818D RID: 164237 RVA: 0x003D0695 File Offset: 0x003CE895
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkUInt32Wrapper(Pointer, MemoryOwner);
		}

		// Token: 0x0401600B RID: 90123
		[Nullable(1)]
		public const string __ObjectPath = "/Script/WwiseObjectUtils.AkUInt32Wrapper";

		// Token: 0x0401600C RID: 90124
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401600D RID: 90125
		internal static int __PropertyOffset_UInt32Value;
	}
}
