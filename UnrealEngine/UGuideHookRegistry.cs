using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000661 RID: 1633
	[UnrealObjectPath("/Script/LGUI.GuideHookRegistry")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public class UGuideHookRegistry : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008DAE RID: 36270 RVA: 0x000D55DA File Offset: 0x000D37DA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGuideHookRegistry._ClassPtr;
		}

		// Token: 0x06008DAF RID: 36271 RVA: 0x000D55E8 File Offset: 0x000D37E8
		public UGuideHookRegistry() : this(BuiltinUtils.AllocNativeUObject(UGuideHookRegistry.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008DB0 RID: 36272 RVA: 0x000D5610 File Offset: 0x000D3810
		[NullableContext(1)]
		public UGuideHookRegistry(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGuideHookRegistry.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001AD8 RID: 6872
		// (get) Token: 0x06008DB1 RID: 36273 RVA: 0x000D5644 File Offset: 0x000D3844
		// (set) Token: 0x06008DB2 RID: 36274 RVA: 0x000D567D File Offset: 0x000D387D
		[Nullable(new byte[]
		{
			1,
			1,
			0,
			1
		})]
		public TMap<string, TWeakObjectPtr<AActor>> GuideHookComponents
		{
			[return: Nullable(new byte[]
			{
				1,
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<string, TWeakObjectPtr<AActor>> result;
				if ((result = this._GuideHookComponents) == null)
				{
					result = (this._GuideHookComponents = new TMap<string, TWeakObjectPtr<AActor>>(base.NativePtr + (IntPtr)UGuideHookRegistry.__PropertyOffset_GuideHookComponents, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				1,
				0,
				1
			})]
			set
			{
				this.GuideHookComponents.CopyAssign(value);
			}
		}

		// Token: 0x06008DB3 RID: 36275 RVA: 0x000D568B File Offset: 0x000D388B
		static UGuideHookRegistry()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.GuideHookRegistry");
		}

		// Token: 0x06008DB4 RID: 36276 RVA: 0x000D5699 File Offset: 0x000D3899
		protected UGuideHookRegistry(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003E6F RID: 15983
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.GuideHookRegistry";

		// Token: 0x04003E70 RID: 15984
		private static IntPtr _ClassPtr;

		// Token: 0x04003E71 RID: 15985
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003E72 RID: 15986
		internal static int __PropertyOffset_GuideHookComponents;

		// Token: 0x04003E73 RID: 15987
		[Nullable(new byte[]
		{
			2,
			1,
			0,
			1
		})]
		private TMap<string, TWeakObjectPtr<AActor>> _GuideHookComponents;
	}
}
