using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000709 RID: 1801
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIGuideMarkComponent")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UUIGuideMarkComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009978 RID: 39288 RVA: 0x000E6DEB File Offset: 0x000E4FEB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIGuideMarkComponent._ClassPtr;
		}

		// Token: 0x06009979 RID: 39289 RVA: 0x000E6DF8 File Offset: 0x000E4FF8
		public UUIGuideMarkComponent() : this(BuiltinUtils.AllocNativeUObject(UUIGuideMarkComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600997A RID: 39290 RVA: 0x000E6E20 File Offset: 0x000E5020
		public UUIGuideMarkComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIGuideMarkComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C84 RID: 7300
		// (get) Token: 0x0600997B RID: 39291 RVA: 0x000E6E53 File Offset: 0x000E5053
		// (set) Token: 0x0600997C RID: 39292 RVA: 0x000E6E63 File Offset: 0x000E5063
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

		// Token: 0x17001C85 RID: 7301
		// (get) Token: 0x0600997D RID: 39293 RVA: 0x000E6E74 File Offset: 0x000E5074
		// (set) Token: 0x0600997E RID: 39294 RVA: 0x000E6E88 File Offset: 0x000E5088
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

		// Token: 0x17001C86 RID: 7302
		// (get) Token: 0x0600997F RID: 39295 RVA: 0x000E6EA0 File Offset: 0x000E50A0
		// (set) Token: 0x06009980 RID: 39296 RVA: 0x000E6ED9 File Offset: 0x000E50D9
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

		// Token: 0x06009981 RID: 39297 RVA: 0x000E6EE7 File Offset: 0x000E50E7
		static UUIGuideMarkComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIGuideMarkComponent");
		}

		// Token: 0x06009982 RID: 39298 RVA: 0x000E6EF5 File Offset: 0x000E50F5
		protected UUIGuideMarkComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040042A7 RID: 17063
		public new const string __ObjectPath = "/Script/LGUI.UIGuideMarkComponent";

		// Token: 0x040042A8 RID: 17064
		private static IntPtr _ClassPtr;

		// Token: 0x040042A9 RID: 17065
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040042AA RID: 17066
		internal static int __PropertyOffset_Type;

		// Token: 0x040042AB RID: 17067
		internal static int __PropertyOffset_Name;

		// Token: 0x040042AC RID: 17068
		internal static int __PropertyOffset_Children;

		// Token: 0x040042AD RID: 17069
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
