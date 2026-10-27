using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007D5 RID: 2005
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AISystemBase")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public abstract class UAISystemBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006AD3 RID: 27347 RVA: 0x00099E9E File Offset: 0x0009809E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAISystemBase._ClassPtr;
		}

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x06006AD4 RID: 27348 RVA: 0x00099EAC File Offset: 0x000980AC
		// (set) Token: 0x06006AD5 RID: 27349 RVA: 0x00099EE5 File Offset: 0x000980E5
		public FSoftClassPath AISystemClassName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._AISystemClassName) == null)
				{
					result = (this._AISystemClassName = new FSoftClassPath(base.NativePtr + (IntPtr)UAISystemBase.__PropertyOffset_AISystemClassName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UAISystemBase.__PropertyOffset_AISystemClassName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x06006AD6 RID: 27350 RVA: 0x00099F06 File Offset: 0x00098106
		// (set) Token: 0x06006AD7 RID: 27351 RVA: 0x00099F1A File Offset: 0x0009811A
		public unsafe FName AISystemModuleName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISystemBase.__PropertyOffset_AISystemModuleName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISystemBase.__PropertyOffset_AISystemModuleName) = value;
			}
		}

		// Token: 0x1700192B RID: 6443
		// (get) Token: 0x06006AD8 RID: 27352 RVA: 0x00099F2F File Offset: 0x0009812F
		// (set) Token: 0x06006AD9 RID: 27353 RVA: 0x00099F3F File Offset: 0x0009813F
		public unsafe bool bInstantiateAISystemOnClient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISystemBase.__PropertyOffset_bInstantiateAISystemOnClient) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISystemBase.__PropertyOffset_bInstantiateAISystemOnClient) = (value ? 1 : 0);
			}
		}

		// Token: 0x06006ADA RID: 27354 RVA: 0x00099F50 File Offset: 0x00098150
		static UAISystemBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AISystemBase");
		}

		// Token: 0x06006ADB RID: 27355 RVA: 0x00099F60 File Offset: 0x00098160
		protected UAISystemBase() : this(BuiltinUtils.AllocNativeUObject(UAISystemBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006ADC RID: 27356 RVA: 0x00099F88 File Offset: 0x00098188
		protected UAISystemBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400336A RID: 13162
		public new const string __ObjectPath = "/Script/Engine.AISystemBase";

		// Token: 0x0400336B RID: 13163
		private static IntPtr _ClassPtr;

		// Token: 0x0400336C RID: 13164
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400336D RID: 13165
		internal static int __PropertyOffset_AISystemClassName;

		// Token: 0x0400336E RID: 13166
		[Nullable(2)]
		private FSoftClassPath _AISystemClassName;

		// Token: 0x0400336F RID: 13167
		internal static int __PropertyOffset_AISystemModuleName;

		// Token: 0x04003370 RID: 13168
		internal static int __PropertyOffset_bInstantiateAISystemOnClient;
	}
}
