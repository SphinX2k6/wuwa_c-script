using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200013B RID: 315
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTDecorator_BlackboardBase")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public abstract class UBTDecorator_BlackboardBase : UBTDecorator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001615 RID: 5653 RVA: 0x000206C0 File Offset: 0x0001E8C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTDecorator_BlackboardBase._ClassPtr;
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001616 RID: 5654 RVA: 0x000206CC File Offset: 0x0001E8CC
		// (set) Token: 0x06001617 RID: 5655 RVA: 0x00020705 File Offset: 0x0001E905
		public FBlackboardKeySelector BlackboardKey
		{
			get
			{
				base.FastCheckIsValid();
				FBlackboardKeySelector result;
				if ((result = this._BlackboardKey) == null)
				{
					result = (this._BlackboardKey = new FBlackboardKeySelector(base.NativePtr + (IntPtr)UBTDecorator_BlackboardBase.__PropertyOffset_BlackboardKey, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBlackboardKeySelector.StaticStruct(), base.NativePtr + (IntPtr)UBTDecorator_BlackboardBase.__PropertyOffset_BlackboardKey, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00020726 File Offset: 0x0001E926
		static UBTDecorator_BlackboardBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTDecorator_BlackboardBase");
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00020734 File Offset: 0x0001E934
		protected UBTDecorator_BlackboardBase() : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_BlackboardBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x0002075C File Offset: 0x0001E95C
		protected UBTDecorator_BlackboardBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040004E6 RID: 1254
		public new const string __ObjectPath = "/Script/AIModule.BTDecorator_BlackboardBase";

		// Token: 0x040004E7 RID: 1255
		private static IntPtr _ClassPtr;

		// Token: 0x040004E8 RID: 1256
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040004E9 RID: 1257
		internal static int __PropertyOffset_BlackboardKey;

		// Token: 0x040004EA RID: 1258
		[Nullable(2)]
		private FBlackboardKeySelector _BlackboardKey;
	}
}
