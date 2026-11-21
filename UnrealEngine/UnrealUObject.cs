using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000087 RID: 135
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class UnrealUObject : UnrealObject
	{
		// Token: 0x06000C35 RID: 3125 RVA: 0x00013D07 File Offset: 0x00011F07
		protected UnrealUObject()
		{
			throw new Exception("UnrealUObject cannot be instantiated by script.");
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00013D19 File Offset: 0x00011F19
		protected UnrealUObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
			BuiltinUtils.BindNativeUObject(this);
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00013D28 File Offset: 0x00011F28
		~UnrealUObject()
		{
			if (this._NativePtr != IntPtr.Zero)
			{
				BuiltinUtils.UnbindNativeUObject_GCThread(this._NativePtr);
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x00013D68 File Offset: 0x00011F68
		public int ObjectIndex
		{
			get
			{
				return UnrealUObject.Internal_ObjectIndex(this._NativePtr);
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000C39 RID: 3129 RVA: 0x00013D75 File Offset: 0x00011F75
		public int ObjectSerialNumber
		{
			get
			{
				return UnrealUObject.Internal_ObjectSerialNumber(this._NativePtr);
			}
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00013D82 File Offset: 0x00011F82
		public override bool IsValid()
		{
			return this._NativePtr != IntPtr.Zero && UObjectGlobals.IsValid(this._NativePtr);
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00013D9E File Offset: 0x00011F9E
		public UClassStackOnlyPtr GetClass()
		{
			base.FastCheckIsValid();
			return UnrealUObject.Internal_GetClass(this._NativePtr);
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x00013DB1 File Offset: 0x00011FB1
		public string GetName()
		{
			base.FastCheckIsValid();
			return UnrealUObject.Internal_GetName(this._NativePtr);
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00013DC4 File Offset: 0x00011FC4
		public FName GetFName()
		{
			base.FastCheckIsValid();
			return UnrealUObject.Internal_GetFName(this._NativePtr);
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00013DD7 File Offset: 0x00011FD7
		public string GetPathName()
		{
			base.FastCheckIsValid();
			return UnrealUObject.Internal_GetPathName(this._NativePtr);
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00013DEA File Offset: 0x00011FEA
		public bool IsA(UClassStackOnlyPtr ClassPtr)
		{
			base.FastCheckIsValid();
			return UnrealUObject.Internal_IsA(this._NativePtr, ClassPtr);
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00013DFE File Offset: 0x00011FFE
		public bool IsA<[Nullable(0)] T>() where T : UnrealUObject, IUnrealUObject
		{
			return this.IsA(IUnrealUObject.StaticClass());
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00013E11 File Offset: 0x00012011
		public sealed override string ToString()
		{
			if (!this.IsValid())
			{
				return "InvalidObject";
			}
			return this.GetName();
		}

		// Token: 0x06000C42 RID: 3138
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int Internal_ObjectIndex(IntPtr ObjectPtr);

		// Token: 0x06000C43 RID: 3139
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int Internal_ObjectSerialNumber(IntPtr ObjectPtr);

		// Token: 0x06000C44 RID: 3140
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern UClassStackOnlyPtr Internal_GetClass(IntPtr ObjectPtr);

		// Token: 0x06000C45 RID: 3141
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string Internal_GetName(IntPtr ObjectPtr);

		// Token: 0x06000C46 RID: 3142
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern FName Internal_GetFName(IntPtr ObjectPtr);

		// Token: 0x06000C47 RID: 3143
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string Internal_GetPathName(IntPtr ObjectPtr);

		// Token: 0x06000C48 RID: 3144
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool Internal_IsA(IntPtr ObjectPtr, UClassStackOnlyPtr ClassPtr);
	}
}
