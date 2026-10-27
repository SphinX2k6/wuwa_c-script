using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A03 RID: 10755
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.WidgetNavigation")]
	[UnrealStructLayout(432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UWidgetNavigation : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027FCD RID: 163789 RVA: 0x003CE058 File Offset: 0x003CC258
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWidgetNavigation._ClassPtr;
		}

		// Token: 0x06027FCE RID: 163790 RVA: 0x003CE064 File Offset: 0x003CC264
		public UWidgetNavigation() : this(BuiltinUtils.AllocNativeUObject(UWidgetNavigation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027FCF RID: 163791 RVA: 0x003CE08C File Offset: 0x003CC28C
		public UWidgetNavigation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWidgetNavigation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170098C1 RID: 39105
		// (get) Token: 0x06027FD0 RID: 163792 RVA: 0x003CE0C0 File Offset: 0x003CC2C0
		// (set) Token: 0x06027FD1 RID: 163793 RVA: 0x003CE0F9 File Offset: 0x003CC2F9
		public FWidgetNavigationData Up
		{
			get
			{
				base.FastCheckIsValid();
				FWidgetNavigationData result;
				if ((result = this._Up) == null)
				{
					result = (this._Up = new FWidgetNavigationData(base.NativePtr + (IntPtr)UWidgetNavigation.__PropertyOffset_Up, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWidgetNavigationData.StaticStruct(), base.NativePtr + (IntPtr)UWidgetNavigation.__PropertyOffset_Up, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170098C2 RID: 39106
		// (get) Token: 0x06027FD2 RID: 163794 RVA: 0x003CE11C File Offset: 0x003CC31C
		// (set) Token: 0x06027FD3 RID: 163795 RVA: 0x003CE155 File Offset: 0x003CC355
		public FWidgetNavigationData Down
		{
			get
			{
				base.FastCheckIsValid();
				FWidgetNavigationData result;
				if ((result = this._Down) == null)
				{
					result = (this._Down = new FWidgetNavigationData(base.NativePtr + (IntPtr)UWidgetNavigation.__PropertyOffset_Down, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWidgetNavigationData.StaticStruct(), base.NativePtr + (IntPtr)UWidgetNavigation.__PropertyOffset_Down, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170098C3 RID: 39107
		// (get) Token: 0x06027FD4 RID: 163796 RVA: 0x003CE178 File Offset: 0x003CC378
		// (set) Token: 0x06027FD5 RID: 163797 RVA: 0x003CE1B1 File Offset: 0x003CC3B1
		public FWidgetNavigationData Left
		{
			get
			{
				base.FastCheckIsValid();
				FWidgetNavigationData result;
				if ((result = this._Left) == null)
				{
					result = (this._Left = new FWidgetNavigationData(base.NativePtr + (IntPtr)UWidgetNavigation.__PropertyOffset_Left, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWidgetNavigationData.StaticStruct(), base.NativePtr + (IntPtr)UWidgetNavigation.__PropertyOffset_Left, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170098C4 RID: 39108
		// (get) Token: 0x06027FD6 RID: 163798 RVA: 0x003CE1D4 File Offset: 0x003CC3D4
		// (set) Token: 0x06027FD7 RID: 163799 RVA: 0x003CE20D File Offset: 0x003CC40D
		public FWidgetNavigationData Right
		{
			get
			{
				base.FastCheckIsValid();
				FWidgetNavigationData result;
				if ((result = this._Right) == null)
				{
					result = (this._Right = new FWidgetNavigationData(base.NativePtr + (IntPtr)UWidgetNavigation.__PropertyOffset_Right, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWidgetNavigationData.StaticStruct(), base.NativePtr + (IntPtr)UWidgetNavigation.__PropertyOffset_Right, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170098C5 RID: 39109
		// (get) Token: 0x06027FD8 RID: 163800 RVA: 0x003CE230 File Offset: 0x003CC430
		// (set) Token: 0x06027FD9 RID: 163801 RVA: 0x003CE269 File Offset: 0x003CC469
		public FWidgetNavigationData Next
		{
			get
			{
				base.FastCheckIsValid();
				FWidgetNavigationData result;
				if ((result = this._Next) == null)
				{
					result = (this._Next = new FWidgetNavigationData(base.NativePtr + (IntPtr)UWidgetNavigation.__PropertyOffset_Next, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWidgetNavigationData.StaticStruct(), base.NativePtr + (IntPtr)UWidgetNavigation.__PropertyOffset_Next, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170098C6 RID: 39110
		// (get) Token: 0x06027FDA RID: 163802 RVA: 0x003CE28C File Offset: 0x003CC48C
		// (set) Token: 0x06027FDB RID: 163803 RVA: 0x003CE2C5 File Offset: 0x003CC4C5
		public FWidgetNavigationData Previous
		{
			get
			{
				base.FastCheckIsValid();
				FWidgetNavigationData result;
				if ((result = this._Previous) == null)
				{
					result = (this._Previous = new FWidgetNavigationData(base.NativePtr + (IntPtr)UWidgetNavigation.__PropertyOffset_Previous, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWidgetNavigationData.StaticStruct(), base.NativePtr + (IntPtr)UWidgetNavigation.__PropertyOffset_Previous, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06027FDC RID: 163804 RVA: 0x003CE2E6 File Offset: 0x003CC4E6
		static UWidgetNavigation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.WidgetNavigation");
		}

		// Token: 0x06027FDD RID: 163805 RVA: 0x003CE2F4 File Offset: 0x003CC4F4
		protected UWidgetNavigation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D2E RID: 89390
		public new const string __ObjectPath = "/Script/UMG.WidgetNavigation";

		// Token: 0x04015D2F RID: 89391
		private static IntPtr _ClassPtr;

		// Token: 0x04015D30 RID: 89392
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015D31 RID: 89393
		internal static int __PropertyOffset_Up;

		// Token: 0x04015D32 RID: 89394
		[Nullable(2)]
		private FWidgetNavigationData _Up;

		// Token: 0x04015D33 RID: 89395
		internal static int __PropertyOffset_Down;

		// Token: 0x04015D34 RID: 89396
		[Nullable(2)]
		private FWidgetNavigationData _Down;

		// Token: 0x04015D35 RID: 89397
		internal static int __PropertyOffset_Left;

		// Token: 0x04015D36 RID: 89398
		[Nullable(2)]
		private FWidgetNavigationData _Left;

		// Token: 0x04015D37 RID: 89399
		internal static int __PropertyOffset_Right;

		// Token: 0x04015D38 RID: 89400
		[Nullable(2)]
		private FWidgetNavigationData _Right;

		// Token: 0x04015D39 RID: 89401
		internal static int __PropertyOffset_Next;

		// Token: 0x04015D3A RID: 89402
		[Nullable(2)]
		private FWidgetNavigationData _Next;

		// Token: 0x04015D3B RID: 89403
		internal static int __PropertyOffset_Previous;

		// Token: 0x04015D3C RID: 89404
		[Nullable(2)]
		private FWidgetNavigationData _Previous;
	}
}
