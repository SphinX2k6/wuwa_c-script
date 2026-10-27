using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002176 RID: 8566
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIGuideMarkComponent")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UUIGuideMarkComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060205B5 RID: 132533 RVA: 0x003007F8 File Offset: 0x002FE9F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIGuideMarkComponent._ClassPtr;
		}

		// Token: 0x060205B6 RID: 132534 RVA: 0x00300804 File Offset: 0x002FEA04
		public UUIGuideMarkComponent() : this(BuiltinUtils.AllocNativeUObject(UUIGuideMarkComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060205B7 RID: 132535 RVA: 0x0030082C File Offset: 0x002FEA2C
		public UUIGuideMarkComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIGuideMarkComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007ECF RID: 32463
		// (get) Token: 0x060205B8 RID: 132536 RVA: 0x0030085F File Offset: 0x002FEA5F
		// (set) Token: 0x060205B9 RID: 132537 RVA: 0x0030086F File Offset: 0x002FEA6F
		public unsafe EUIGuideMarkType Type
		{
			get
			{
				return (EUIGuideMarkType)(*(base.NativePtr + (IntPtr)UUIGuideMarkComponent.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGuideMarkComponent.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x17007ED0 RID: 32464
		// (get) Token: 0x060205BA RID: 132538 RVA: 0x00300880 File Offset: 0x002FEA80
		// (set) Token: 0x060205BB RID: 132539 RVA: 0x00300894 File Offset: 0x002FEA94
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UUIGuideMarkComponent.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UUIGuideMarkComponent.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17007ED1 RID: 32465
		// (get) Token: 0x060205BC RID: 132540 RVA: 0x003008AC File Offset: 0x002FEAAC
		// (set) Token: 0x060205BD RID: 132541 RVA: 0x003008E5 File Offset: 0x002FEAE5
		[Nullable(new byte[]
		{
			1,
			1,
			0,
			1
		})]
		public TMap<string, TWeakObjectPtr<AActor>> Children
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
				if ((result = this._Children) == null)
				{
					result = (this._Children = new TMap<string, TWeakObjectPtr<AActor>>(base.NativePtr + (IntPtr)UUIGuideMarkComponent.__PropertyOffset_Children, this));
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
				this.Children.CopyAssign(value);
			}
		}

		// Token: 0x060205BE RID: 132542 RVA: 0x003008F3 File Offset: 0x002FEAF3
		static UUIGuideMarkComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIGuideMarkComponent");
		}

		// Token: 0x060205BF RID: 132543 RVA: 0x00300901 File Offset: 0x002FEB01
		protected UUIGuideMarkComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011600 RID: 71168
		public new const string __ObjectPath = "/Script/LGUI.UIGuideMarkComponent";

		// Token: 0x04011601 RID: 71169
		private static IntPtr _ClassPtr;

		// Token: 0x04011602 RID: 71170
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011603 RID: 71171
		internal static int __PropertyOffset_Type;

		// Token: 0x04011604 RID: 71172
		internal static int __PropertyOffset_Name;

		// Token: 0x04011605 RID: 71173
		internal static int __PropertyOffset_Children;

		// Token: 0x04011606 RID: 71174
		[Nullable(new byte[]
		{
			2,
			1,
			0,
			1
		})]
		private TMap<string, TWeakObjectPtr<AActor>> _Children;
	}
}
