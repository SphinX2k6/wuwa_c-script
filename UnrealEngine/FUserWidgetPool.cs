using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020029EF RID: 10735
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.UserWidgetPool")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FUserWidgetPool : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027D08 RID: 163080 RVA: 0x003CAB25 File Offset: 0x003C8D25
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FUserWidgetPool._ScriptStructPtr != 0) ? FUserWidgetPool._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/UMG.UserWidgetPool", ref FUserWidgetPool._ScriptStructPtr);
		}

		// Token: 0x1700985C RID: 39004
		// (get) Token: 0x06027D09 RID: 163081 RVA: 0x003CAB4C File Offset: 0x003C8D4C
		// (set) Token: 0x06027D0A RID: 163082 RVA: 0x003CAB8F File Offset: 0x003C8D8F
		public TArray<UUserWidget> ActiveWidgets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UUserWidget> result;
				if ((result = this._ActiveWidgets) == null)
				{
					result = (this._ActiveWidgets = new TArray<UUserWidget>(base.NativePtr + (IntPtr)FUserWidgetPool.__PropertyOffset_ActiveWidgets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ActiveWidgets.CopyAssign(value);
			}
		}

		// Token: 0x1700985D RID: 39005
		// (get) Token: 0x06027D0B RID: 163083 RVA: 0x003CABA0 File Offset: 0x003C8DA0
		// (set) Token: 0x06027D0C RID: 163084 RVA: 0x003CABE3 File Offset: 0x003C8DE3
		public TArray<UUserWidget> InactiveWidgets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UUserWidget> result;
				if ((result = this._InactiveWidgets) == null)
				{
					result = (this._InactiveWidgets = new TArray<UUserWidget>(base.NativePtr + (IntPtr)FUserWidgetPool.__PropertyOffset_InactiveWidgets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InactiveWidgets.CopyAssign(value);
			}
		}

		// Token: 0x06027D0D RID: 163085 RVA: 0x003CABF1 File Offset: 0x003C8DF1
		public FUserWidgetPool()
		{
		}

		// Token: 0x06027D0E RID: 163086 RVA: 0x003CABF9 File Offset: 0x003C8DF9
		public FUserWidgetPool(TArray<UUserWidget> ActiveWidgets, TArray<UUserWidget> InactiveWidgets)
		{
			this.ActiveWidgets = ActiveWidgets;
			this.InactiveWidgets = InactiveWidgets;
		}

		// Token: 0x06027D0F RID: 163087 RVA: 0x003CAC0F File Offset: 0x003C8E0F
		protected override IntPtr GetUStructPtr()
		{
			return FUserWidgetPool.StaticStruct();
		}

		// Token: 0x06027D10 RID: 163088 RVA: 0x003CAC1B File Offset: 0x003C8E1B
		[NullableContext(2)]
		public FUserWidgetPool(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027D11 RID: 163089 RVA: 0x003CAC25 File Offset: 0x003C8E25
		public FUserWidgetPool(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027D12 RID: 163090 RVA: 0x003CAC30 File Offset: 0x003C8E30
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FUserWidgetPool(Pointer, false, true);
		}

		// Token: 0x06027D13 RID: 163091 RVA: 0x003CAC3A File Offset: 0x003C8E3A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FUserWidgetPool(Pointer, MemoryOwner);
		}

		// Token: 0x04015C5F RID: 89183
		public const string __ObjectPath = "/Script/UMG.UserWidgetPool";

		// Token: 0x04015C60 RID: 89184
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015C61 RID: 89185
		internal static int __PropertyOffset_ActiveWidgets;

		// Token: 0x04015C62 RID: 89186
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUserWidget> _ActiveWidgets;

		// Token: 0x04015C63 RID: 89187
		internal static int __PropertyOffset_InactiveWidgets;

		// Token: 0x04015C64 RID: 89188
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUserWidget> _InactiveWidgets;
	}
}
