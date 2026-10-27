using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000A2 RID: 162
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class UnrealUObject : UnrealObject
	{
		// Token: 0x060010A2 RID: 4258 RVA: 0x00018FE3 File Offset: 0x000171E3
		protected UnrealUObject()
		{
			throw new Exception("UnrealUObject cannot be instantiated by script.");
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x00018FF5 File Offset: 0x000171F5
		protected UnrealUObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
			BuiltinUtils.BindNativeUObject(this);
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x00019004 File Offset: 0x00017204
		~UnrealUObject()
		{
			if (this._NativePtr != IntPtr.Zero)
			{
				BuiltinUtils.UnbindNativeUObject_GCThread(this._NativePtr);
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x00019044 File Offset: 0x00017244
		public int ObjectIndex
		{
			get
			{
				return UnrealUObject.Internal_ObjectIndex(this._NativePtr);
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x00019051 File Offset: 0x00017251
		public int ObjectSerialNumber
		{
			get
			{
				return UnrealUObject.Internal_ObjectSerialNumber(this._NativePtr);
			}
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0001905E File Offset: 0x0001725E
		public override bool IsValid()
		{
			return this._NativePtr != IntPtr.Zero && UObjectGlobals.IsValid(this._NativePtr);
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x0001907A File Offset: 0x0001727A
		public UClassStackOnlyPtr GetClass()
		{
			base.FastCheckIsValid();
			return UnrealUObject.Internal_GetClass(this._NativePtr);
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0001908D File Offset: 0x0001728D
		public string GetName()
		{
			base.FastCheckIsValid();
			return UnrealUObject.Internal_GetName(this._NativePtr);
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x000190A0 File Offset: 0x000172A0
		public FName GetFName()
		{
			base.FastCheckIsValid();
			return UnrealUObject.Internal_GetFName(this._NativePtr);
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x000190B3 File Offset: 0x000172B3
		public string GetPathName()
		{
			base.FastCheckIsValid();
			return UnrealUObject.Internal_GetPathName(this._NativePtr);
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x000190C6 File Offset: 0x000172C6
		public bool IsA(UClassStackOnlyPtr ClassPtr)
		{
			base.FastCheckIsValid();
			return UnrealUObject.Internal_IsA(this._NativePtr, ClassPtr);
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x000190DA File Offset: 0x000172DA
		public bool IsA<[Nullable(0)] T>() where T : UnrealUObject, IUnrealUObject
		{
			return this.IsA(IUnrealUObject.StaticClass());
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x000190ED File Offset: 0x000172ED
		public sealed override string ToString()
		{
			if (!this.IsValid())
			{
				return "InvalidObject";
			}
			return this.GetName();
		}

		// Token: 0x060010AF RID: 4271
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int Internal_ObjectIndex(IntPtr ObjectPtr);

		// Token: 0x060010B0 RID: 4272
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int Internal_ObjectSerialNumber(IntPtr ObjectPtr);

		// Token: 0x060010B1 RID: 4273
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern UClassStackOnlyPtr Internal_GetClass(IntPtr ObjectPtr);

		// Token: 0x060010B2 RID: 4274
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string Internal_GetName(IntPtr ObjectPtr);

		// Token: 0x060010B3 RID: 4275
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern FName Internal_GetFName(IntPtr ObjectPtr);

		// Token: 0x060010B4 RID: 4276
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string Internal_GetPathName(IntPtr ObjectPtr);

		// Token: 0x060010B5 RID: 4277
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool Internal_IsA(IntPtr ObjectPtr, UClassStackOnlyPtr ClassPtr);
	}
}
