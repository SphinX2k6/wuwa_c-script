using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A7A RID: 10874
	[UnrealObjectPath("/Script/WwiseObjectUtils.AkUInt64Wrapper")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FAkUInt64Wrapper : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602818E RID: 164238 RVA: 0x003D069E File Offset: 0x003CE89E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkUInt64Wrapper._ScriptStructPtr != 0) ? FAkUInt64Wrapper._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseObjectUtils.AkUInt64Wrapper", ref FAkUInt64Wrapper._ScriptStructPtr);
		}

		// Token: 0x1700991B RID: 39195
		// (get) Token: 0x0602818F RID: 164239 RVA: 0x003D06C2 File Offset: 0x003CE8C2
		// (set) Token: 0x06028190 RID: 164240 RVA: 0x003D06D2 File Offset: 0x003CE8D2
		public unsafe ulong UInt64Value
		{
			get
			{
				return (ulong)(*(base.NativePtr + (IntPtr)FAkUInt64Wrapper.__PropertyOffset_UInt64Value));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkUInt64Wrapper.__PropertyOffset_UInt64Value) = (long)value;
			}
		}

		// Token: 0x06028191 RID: 164241 RVA: 0x003D06E3 File Offset: 0x003CE8E3
		public FAkUInt64Wrapper()
		{
		}

		// Token: 0x06028192 RID: 164242 RVA: 0x003D06EB File Offset: 0x003CE8EB
		public FAkUInt64Wrapper(ulong UInt64Value)
		{
			this.UInt64Value = UInt64Value;
		}

		// Token: 0x06028193 RID: 164243 RVA: 0x003D06FA File Offset: 0x003CE8FA
		protected override IntPtr GetUStructPtr()
		{
			return FAkUInt64Wrapper.StaticStruct();
		}

		// Token: 0x06028194 RID: 164244 RVA: 0x003D0706 File Offset: 0x003CE906
		[NullableContext(2)]
		public FAkUInt64Wrapper(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028195 RID: 164245 RVA: 0x003D0710 File Offset: 0x003CE910
		public FAkUInt64Wrapper(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028196 RID: 164246 RVA: 0x003D071B File Offset: 0x003CE91B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkUInt64Wrapper(Pointer, false, true);
		}

		// Token: 0x06028197 RID: 164247 RVA: 0x003D0725 File Offset: 0x003CE925
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkUInt64Wrapper(Pointer, MemoryOwner);
		}

		// Token: 0x0401600E RID: 90126
		[Nullable(1)]
		public const string __ObjectPath = "/Script/WwiseObjectUtils.AkUInt64Wrapper";

		// Token: 0x0401600F RID: 90127
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016010 RID: 90128
		internal static int __PropertyOffset_UInt64Value;
	}
}
