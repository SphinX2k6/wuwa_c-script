using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000153 RID: 339
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTTaskNode")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public abstract class UBTTaskNode : UBTNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001768 RID: 5992 RVA: 0x000226F5 File Offset: 0x000208F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTaskNode._ClassPtr;
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x00022704 File Offset: 0x00020904
		// (set) Token: 0x0600176A RID: 5994 RVA: 0x0002273D File Offset: 0x0002093D
		public TArray<UBTService> Services
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UBTService> result;
				if ((result = this._Services) == null)
				{
					result = (this._Services = new TArray<UBTService>(base.NativePtr + (IntPtr)UBTTaskNode.__PropertyOffset_Services, this));
				}
				return result;
			}
			set
			{
				this.Services.CopyAssign(value);
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x0600176B RID: 5995 RVA: 0x0002274B File Offset: 0x0002094B
		// (set) Token: 0x0600176C RID: 5996 RVA: 0x00022764 File Offset: 0x00020964
		public unsafe bool bIgnoreRestartSelf
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTTaskNode.__PropertyOffset_bIgnoreRestartSelf) & UBTTaskNode.__PropertyMask_bIgnoreRestartSelf) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTTaskNode.__PropertyOffset_bIgnoreRestartSelf) = ((*(base.NativePtr + (IntPtr)UBTTaskNode.__PropertyOffset_bIgnoreRestartSelf) & ~UBTTaskNode.__PropertyMask_bIgnoreRestartSelf) | (value ? UBTTaskNode.__PropertyMask_bIgnoreRestartSelf : 0));
			}
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x00022794 File Offset: 0x00020994
		static UBTTaskNode()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTTaskNode");
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x000227A4 File Offset: 0x000209A4
		protected UBTTaskNode() : this(BuiltinUtils.AllocNativeUObject(UBTTaskNode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x000227CC File Offset: 0x000209CC
		protected UBTTaskNode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400058A RID: 1418
		public new const string __ObjectPath = "/Script/AIModule.BTTaskNode";

		// Token: 0x0400058B RID: 1419
		private static IntPtr _ClassPtr;

		// Token: 0x0400058C RID: 1420
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400058D RID: 1421
		internal static int __PropertyOffset_Services;

		// Token: 0x0400058E RID: 1422
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBTService> _Services;

		// Token: 0x0400058F RID: 1423
		internal static int __PropertyOffset_bIgnoreRestartSelf;

		// Token: 0x04000590 RID: 1424
		internal static byte __PropertyMask_bIgnoreRestartSelf;
	}
}
