using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A04 RID: 10756
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.WidgetNavigationData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FWidgetNavigationData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027FDE RID: 163806 RVA: 0x003CE2FD File Offset: 0x003CC4FD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWidgetNavigationData._ScriptStructPtr != 0) ? FWidgetNavigationData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/UMG.WidgetNavigationData", ref FWidgetNavigationData._ScriptStructPtr);
		}

		// Token: 0x170098C7 RID: 39111
		// (get) Token: 0x06027FDF RID: 163807 RVA: 0x003CE321 File Offset: 0x003CC521
		// (set) Token: 0x06027FE0 RID: 163808 RVA: 0x003CE331 File Offset: 0x003CC531
		public unsafe EUINavigationRule Rule
		{
			get
			{
				return (EUINavigationRule)(*(base.NativePtr + (IntPtr)FWidgetNavigationData.__PropertyOffset_Rule));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWidgetNavigationData.__PropertyOffset_Rule) = (byte)value;
			}
		}

		// Token: 0x170098C8 RID: 39112
		// (get) Token: 0x06027FE1 RID: 163809 RVA: 0x003CE342 File Offset: 0x003CC542
		// (set) Token: 0x06027FE2 RID: 163810 RVA: 0x003CE356 File Offset: 0x003CC556
		public unsafe FName WidgetToFocus
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWidgetNavigationData.__PropertyOffset_WidgetToFocus);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWidgetNavigationData.__PropertyOffset_WidgetToFocus) = value;
			}
		}

		// Token: 0x170098C9 RID: 39113
		// (get) Token: 0x06027FE3 RID: 163811 RVA: 0x003CE36B File Offset: 0x003CC56B
		// (set) Token: 0x06027FE4 RID: 163812 RVA: 0x003CE37F File Offset: 0x003CC57F
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UWidget> Widget
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FWidgetNavigationData.__PropertyOffset_Widget);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FWidgetNavigationData.__PropertyOffset_Widget) = value;
			}
		}

		// Token: 0x170098CA RID: 39114
		// (get) Token: 0x06027FE5 RID: 163813 RVA: 0x003CE394 File Offset: 0x003CC594
		// (set) Token: 0x06027FE6 RID: 163814 RVA: 0x003CE3D7 File Offset: 0x003CC5D7
		public FCustomWidgetNavigationDelegate CustomDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FCustomWidgetNavigationDelegate result;
				if ((result = this._CustomDelegate) == null)
				{
					result = (this._CustomDelegate = new FCustomWidgetNavigationDelegate(base.NativePtr + (IntPtr)FWidgetNavigationData.__PropertyOffset_CustomDelegate, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)FWidgetNavigationData.__PropertyOffset_CustomDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06027FE7 RID: 163815 RVA: 0x003CE3F8 File Offset: 0x003CC5F8
		public FWidgetNavigationData()
		{
		}

		// Token: 0x06027FE8 RID: 163816 RVA: 0x003CE400 File Offset: 0x003CC600
		public FWidgetNavigationData(EUINavigationRule Rule, FName WidgetToFocus, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UWidget> Widget, FCustomWidgetNavigationDelegate CustomDelegate)
		{
			this.Rule = Rule;
			this.WidgetToFocus = WidgetToFocus;
			this.Widget = Widget;
			this.CustomDelegate = CustomDelegate;
		}

		// Token: 0x06027FE9 RID: 163817 RVA: 0x003CE425 File Offset: 0x003CC625
		protected override IntPtr GetUStructPtr()
		{
			return FWidgetNavigationData.StaticStruct();
		}

		// Token: 0x06027FEA RID: 163818 RVA: 0x003CE431 File Offset: 0x003CC631
		[NullableContext(2)]
		public FWidgetNavigationData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027FEB RID: 163819 RVA: 0x003CE43B File Offset: 0x003CC63B
		public FWidgetNavigationData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027FEC RID: 163820 RVA: 0x003CE446 File Offset: 0x003CC646
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWidgetNavigationData(Pointer, false, true);
		}

		// Token: 0x06027FED RID: 163821 RVA: 0x003CE450 File Offset: 0x003CC650
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWidgetNavigationData(Pointer, MemoryOwner);
		}

		// Token: 0x04015D3D RID: 89405
		public const string __ObjectPath = "/Script/UMG.WidgetNavigationData";

		// Token: 0x04015D3E RID: 89406
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015D3F RID: 89407
		internal static int __PropertyOffset_Rule;

		// Token: 0x04015D40 RID: 89408
		internal static int __PropertyOffset_WidgetToFocus;

		// Token: 0x04015D41 RID: 89409
		internal static int __PropertyOffset_Widget;

		// Token: 0x04015D42 RID: 89410
		internal static int __PropertyOffset_CustomDelegate;

		// Token: 0x04015D43 RID: 89411
		[Nullable(2)]
		private FCustomWidgetNavigationDelegate _CustomDelegate;
	}
}
